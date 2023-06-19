using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSytem.Includes;


namespace PayrollSytem
{
    public partial class frm_Payroll : Form
    {
        public frm_Payroll()
        {
            InitializeComponent();
        }

        int overtime = 0;
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string connectionString = "server=localhost;user id=root;database=payrolldb;sslMode=none";
        string sql;

        private void calc_on_dedution()
        {
            try
            {
                double ca, phic, pagibig, d1, d2, d3, d4, total_deduction, gross, total_net;

                ca = double.Parse(txtpcadvance.Text);
                phic = double.Parse(txtpphic.Text);
                pagibig = double.Parse(txtppagibig.Text);
                d1 = double.Parse(txtpdeduct1.Text);
                d2 = double.Parse(txtpdeduct2.Text);
                d3 = double.Parse(txtpdeduct3.Text);
                d4 = double.Parse(txtpdeduct4.Text);
                gross = double.Parse(txtpgincome.Text);

                total_deduction = ca + phic + pagibig + d1 + d2 + d3 + d4;
                txtpdeducttot.Text = total_deduction.ToString();

                total_net = gross - total_deduction;
                txtpnetincome.Text = total_net.ToString();
            }
            catch
            {

            }
           
        }

        private void load_data()
        {
            sql = "SELECT DISTINCT (" +
              "p.`trans_id`" +
              "),e.emp_code as 'Assign Code', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ,  ' ',  `emp_mname` ) AS  'Employee'" +
              ",  `d_rate` AS 'DailyRate' ,  `num_days` AS 'NumberOfDays' ,  `r_wage` AS 'RateWage', "
              + " `gross_sal` AS 'GrossIncome', `total_ded` AS 'TotalDeduction',  `net_income` AS 'NetIncome' ,  " +
              " `position` AS 'Postion',`remarks` AS 'Remarks' ,`dateissued` AS 'DateIssued'    " +
              "FROM  `employee` e,  `payroll` p,  `employee_workinfo` ew,  `other_deduction` od " +
              "WHERE e.`emp_code` = p.`emp_code` " +
              "AND p.`emp_code` = ew.`emp_code` " +
              "AND p.`trans_id` = od.`trans_id` " +
              "AND  (emp_fname  LIKE '%" + txtpsearch.Text + "%'" +
              "OR  emp_lname  LIKE '%" + txtpsearch.Text + "%'" +
              "OR e.emp_code LIKE '%" + txtpsearch.Text + "%')";
            config.Load_DTG(sql, dtgParollList);
            dtgParollList.Columns[0].Visible = false;
            funct.ResponsiveDtg(dtgParollList);


            sql = "SELECT concat(autoname,strnum) as auto FROM autonumber WHERE id = 1";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txttrancode.Text = config.dt.Rows[0].Field<string>("auto");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtPEmployeeName.Text = "";
            txtpremarks.Text = "";
            txtPAssignCode.Text = "";
            funct.clearTxt(GroupBox3);
            funct.clearTxt(GroupBox4);
            funct.clearTxt(GroupBox5);
            funct.clearTxt(GroupBox6);
            txtPrateWage.Text = "0";
            txtPregOt.Text = "0";
            txtPholPay.Text = "0";
            txtpgincome.Text = "0";
            txtpnetincome.Text = "0";
            txtpdeducttot.Text = "0";
            txtpcadvance.Text = "0";
            txtpphic.Text = "0";
            txtppagibig.Text = "0";
            txtpdeduct1.Text = "0";
            txtpdeduct2.Text = "0";
            txtpdeduct3.Text = "0";
            txtpdeduct4.Text = "0";


        }

        private void frm_Payroll_Load(object sender, EventArgs e)
        {
            load_data();

           
        
        }

        private void txtPAssignCode_TextChanged(object sender, EventArgs e)
        {
            overtime = 0;
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " 
                + " WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" + txtPAssignCode.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtPRateperday.Text = config.dt.Rows[0].Field<int>("d_rate").ToString();
                txtPPayPeriod.Text = config.dt.Rows[0].Field<string>("p_method").ToString();
                txtPEmployeeName.Text = config.dt.Rows[0].Field<string>("emp_fname").ToString()
                + " " + config.dt.Rows[0].Field<string>("emp_lname").ToString() + " " 
                + config.dt.Rows[0].Field<string>("emp_mname").ToString();
            }
            else
            {
                txtPEmployeeName.Text = "";
                txtpremarks.Text = ""; 
                funct.clearTxt(GroupBox3);
                funct.clearTxt(GroupBox4);
                funct.clearTxt(GroupBox5);
                funct.clearTxt(GroupBox6);
                txtPrateWage.Text = "0";
                txtPregOt.Text = "0";
                txtPholPay.Text = "0";
                txtpgincome.Text = "0";
                txtpnetincome.Text = "0";
                txtpdeducttot.Text = "0";
            }

            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlDataReader rdr;
                con.Open();
                sql = "SELECT * FROM hrsdaysworked WHERE emp_code='" + txtPAssignCode.Text + "'";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                     rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtPNoDays.Text = rdr.GetValue(3).ToString();
                    }
                    rdr.Close();

                }
            }
           

        }

        private void txtPNoDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                double rateWage, grossincome, neticome,ot,holpay;
                int overt = 0;

                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);

                if (txtPNoDays.Text == "" || txtPNoDays.Text == "0")
                {
                    txtPrateWage.Text = "0";
                    rateWage = double.Parse(txtPrateWage.Text);

                }
                else
                {
                    rateWage = double.Parse(txtPRateperday.Text) * double.Parse(txtPNoDays.Text);
                    txtPrateWage.Text = rateWage.ToString();
                }

                RegHrs.Text = (int.Parse(txtPNoDays.Text) * 8).ToString();
                grossincome = rateWage + ot + holpay;
                txtpgincome.Text = grossincome.ToString();


                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();
            }
            catch (Exception ex)
            {

            } 
        }

        private void txtPRegOtHr_TextChanged(object sender, EventArgs e)
        {
            
            try
            { 

              

                double total,total_leghol, total_OT,grossincome , neticome, ot, holpay, rateWage, leghol, restot, regnightdiff, restnightdiff;
                int overt = 0;

                if(txtPRegOtHr.Text=="" || txtPRegOtHr.Text == "0")
                {
                    
                    txtPregOt.Text = "0";
                    overtime = int.Parse(RestDayOT.Text) + int.Parse(txtPRegOtHr.Text);
                }
                else
                {
                    
                    total = Double.Parse(txtPRateperday.Text) / 8;
                    total_OT = total * Double.Parse(txtPRegOtHr.Text);
                    txtPregOt.Text = total_OT.ToString();
                    overtime = int.Parse(RestDayOT.Text) + int.Parse(txtPRegOtHr.Text);

                }
                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                else
                {
                    total_leghol = (double.Parse(txtPRateperday.Text) * double.Parse(LegalHolHrs.Text)) * 2.0;

                    LegalHrsPay.Text = total_leghol.ToString();

                }
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                }
                else
                {
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if (RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1) * double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }
                overt = (int.Parse(txtPNoDays.Text) * 8) - overtime;
          

                RegHrs.Text = overt.ToString();
                  ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);
               
                grossincome = rateWage + ot + holpay + leghol + restot + restnightdiff + regnightdiff ;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            } 
        }
 
        private void txtPholPayDay_TextChanged(object sender, EventArgs e)
        {
            try
            {



                double total_hol,total_leghol, leghol, grossincome, neticome, ot, holpay, rateWage, restot, regnightdiff, restnightdiff;

                if (txtPholPayDay.Text == "" || txtPholPayDay.Text == "0")
                {
                    txtPholPay.Text = "0";
                }
                else
                {
                    total_hol = double.Parse(txtPRateperday.Text) * double.Parse(txtPholPayDay.Text);

                    txtPholPay.Text = total_hol.ToString();

                }
                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                else
                {
                    total_leghol = (double.Parse(txtPRateperday.Text) * double.Parse(LegalHolHrs.Text)) * 2.0;

                    LegalHrsPay.Text = total_leghol.ToString();

                }
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                }
                else
                {
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if (RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1) * double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }
                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);

                grossincome = rateWage + ot + holpay + leghol + restot + restnightdiff + regnightdiff;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            }

        }

        private void txtpcadvance_TextChanged(object sender, EventArgs e)
        {
          

            if(txtpcadvance.Text == "" || txtpcadvance.Text == "0")
            {
                txtpcadvance.Text = "0";

            }

            calc_on_dedution();


        }

        private void txtpphic_TextChanged(object sender, EventArgs e)
        {
            if (txtpphic.Text == "" || txtpphic.Text == "0")
            {
                txtpphic.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtppagibig_TextChanged(object sender, EventArgs e)

        {
            if (txtppagibig.Text == "" || txtppagibig.Text == "0")
            {
                txtppagibig.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct1_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct1.Text == "" || txtpdeduct1.Text == "0")
            {
                txtpdeduct1.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct2_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct2.Text == "" || txtpdeduct2.Text == "0")
            {
                txtpdeduct2.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct3_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct3.Text == "" || txtpdeduct3.Text == "0")
            {
                txtpdeduct3.Text = "0";

            }
            calc_on_dedution();

        }

        private void txtpdeduct4_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct4.Text == "" || txtpdeduct4.Text == "0")
            {
                txtpdeduct4.Text = "0";

            }
            calc_on_dedution();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void txtpsearch_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void txttrancode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpremarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpnetincome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Salary Report", new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(300, 40));
            e.Graphics.DrawString("Evangelista Medical Specialty", new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(150, 100));
            e.Graphics.DrawString("Hospital", new System.Drawing.Font("Arial", 26, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(330, 160));
            e.Graphics.DrawString("Employee Name: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 250));
            e.Graphics.DrawString("Rate per Day: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 300));
            e.Graphics.DrawString("Rate Wage: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 350));
            e.Graphics.DrawString("Reg. OT: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 400));
            e.Graphics.DrawString("Hol. Pay: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 450));
            e.Graphics.DrawString("Gross Income: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 500));
            e.Graphics.DrawString("Total Deductions: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 550));
            e.Graphics.DrawString("Remarks: ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 650));

            //Employee Name 
            e.Graphics.DrawString(txtPEmployeeName.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 250));
           
            e.Graphics.DrawString("Net Income ", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 600));
            e.Graphics.DrawString(txtpnetincome.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 600));

            e.Graphics.DrawString(txtPRateperday.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 300));
            e.Graphics.DrawString(txtPrateWage.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 350));
            e.Graphics.DrawString(txtPregOt.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 400));
            e.Graphics.DrawString(txtPholPay.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 450));
            e.Graphics.DrawString(txtpgincome.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 500));
            e.Graphics.DrawString(txtpdeducttot.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(400, 550));
            e.Graphics.DrawString(txtpremarks.Text, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(50, 680));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dtgParollList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPRateperday_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage8_Click(object sender, EventArgs e)
        {

        }

        private void btnPsave_Click(object sender, EventArgs e)
        {

            if (txtPNoDays.Text == "" || txtPregOt.Text == "" || txtPholPay.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO `other_deduction` "
                               + "(`emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, "
                               + "`ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`,trans_id)"
                               + " VALUES ('" + txtPAssignCode.Text + "','" + txtpdeductname1.Text + "','"
                               + txtpdeduct1.Text + "','" + txtpdeductname2.Text + "','" + txtpdeduct2.Text
                               + "','" + txtpdeductname3.Text + "','" + txtpdeductname3.Text
                               + "','" + txtpdeductname4.Text + "','" + txtpdeductname4.Text
                               + "','" + txtpdeducttot.Text + "','" + txttrancode.Text + "')";
                config.Execute_Query(sql);

                sql = "INSERT INTO  `payroll` "
                    + "(`emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`"
                    + ", `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`,`dateissued`,trans_id)"
                    + " VALUES ('" + txtPAssignCode.Text + "','" + txtPNoDays.Text + "','"
                    + txtPrateWage.Text + "','" + txtPregOt.Text + "','" + txtPholPay.Text
                    + "','" + txtpgincome.Text + "','" + txtpcadvance.Text + "','" + txtbvale.Text
                    + "','" + txtpphic.Text + "','" + txtppagibig.Text + "','" + txtpnetincome.Text
                    + "','" + txtpremarks.Text + "',Now(),'" + txttrancode.Text + "')";

                config.Execute_Query(sql);

                MessageBox.Show("Data has been saved in the database.");

                config.Execute_Query("UPDATE autonumber SET strnum = strnum + increment WHERE id =1");
                txtPAssignCode.Text = "";

                load_data();


            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LegalHolHrs_TextChanged(object sender, EventArgs e)
        {
            try
            {



                double total_leghol, grossincome, neticome, ot, holpay, rateWage, leghol, restot, restnightdiff, regnightdiff;

                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                else
                {
                    total_leghol = (double.Parse(txtPRateperday.Text) * double.Parse(LegalHolHrs.Text)) * 2.0;

                    LegalHrsPay.Text = total_leghol.ToString();

                }
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                }
                else
                {
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if (RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1) * double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }

                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);

                grossincome = rateWage + ot + holpay + leghol + restot + regnightdiff +regnightdiff;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch(Exception ex)
            {

            }
        }

        private void txtPAssignCode_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void RestDayOT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double grossincome, neticome, ot, holpay, rateWage, leghol, restot, restnightdiff, regnightdiff;
                int overt = 0;

                restot = 0;
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                    RestDayOT.Text = "0";
                    overtime = int.Parse(txtPRegOtHr.Text) + int.Parse(RestDayOT.Text);
                }
                else
                {

                    overtime = int.Parse(txtPRegOtHr.Text) + int.Parse(RestDayOT.Text);
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                if (RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1) * double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }

                overt = int.Parse(txtPNoDays.Text) * 8 - overtime;

                RegHrs.Text = overt.ToString();
                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);


                grossincome = rateWage + ot + holpay + leghol + restot + regnightdiff + restnightdiff;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void RegNightDiff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double regnightdiff, restnightdiff, total, total_leghol, total_OT, grossincome, neticome, ot, holpay, rateWage, leghol, restot;


                if (txtPRegOtHr.Text == "" || txtPRegOtHr.Text == "0")
                {
                    txtPregOt.Text = "0";
                }
                else
                {
                    total = Double.Parse(txtPRateperday.Text) / 8;
                    total_OT = total * Double.Parse(txtPRegOtHr.Text);
                    txtPregOt.Text = total_OT.ToString();

                }
                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                else
                {
                    total_leghol = (double.Parse(txtPRateperday.Text) * double.Parse(LegalHolHrs.Text)) * 2.0;

                    LegalHrsPay.Text = total_leghol.ToString();

                }
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                }
                else
                {
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if(RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1 )* double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }
                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);

                grossincome = rateWage + ot + holpay + leghol + restot + regnightdiff + restnightdiff;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            }
        }

        private void RestNightDiff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double regnightdiff, restnightdiff, total, total_leghol, total_OT, grossincome, neticome, ot, holpay, rateWage, leghol, restot;


                if (txtPRegOtHr.Text == "" || txtPRegOtHr.Text == "0")
                {
                    txtPregOt.Text = "0";
                }
                else
                {
                    total = Double.Parse(txtPRateperday.Text) / 8;
                    total_OT = total * Double.Parse(txtPRegOtHr.Text);
                    txtPregOt.Text = total_OT.ToString();

                }
                if (LegalHolHrs.Text == "" || LegalHolHrs.Text == "0")
                {
                    LegalHrsPay.Text = "0";
                }
                else
                {
                    total_leghol = (double.Parse(txtPRateperday.Text) * double.Parse(LegalHolHrs.Text)) * 2.0;

                    LegalHrsPay.Text = total_leghol.ToString();

                }
                if (RestDayOT.Text == "0" || RestDayOT.Text == "")
                {
                    restot = 0;
                }
                else
                {
                    restot = (50.0 * 1.3) * double.Parse(RestDayOT.Text);
                }
                if (RegNightDiff.Text == "0" || RegNightDiff.Text == "")
                {
                    regnightdiff = 0;
                }
                else
                {
                    regnightdiff = (50 * 0.1) * double.Parse(RegNightDiff.Text);
                }
                if (RestNightDiff.Text == "0" || RestNightDiff.Text == "")
                {
                    restnightdiff = 0;
                }
                else
                {
                    restnightdiff = (50 * 0.1 * 1.3) * double.Parse(RestNightDiff.Text);
                }
                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);
                leghol = double.Parse(LegalHrsPay.Text);

                grossincome = rateWage + ot + holpay + leghol + restot + regnightdiff + restnightdiff;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            }
        }

        private void txtPholPay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
