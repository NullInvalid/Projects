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
    public partial class frm_TiTo : Form
    {
        Timer t = new Timer();
        public frm_TiTo()
        {
            InitializeComponent();
        }
        string connectionString = "server=localhost;user id=root;database=payrolldb;sslMode=none";
        int tmrenderall = 0;
        string sql, sql2, sql3;
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void frm_TiTo_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            string suff = "";

            if (hh > 12)
            {

                hh -= 12;
                suff = "PM";

            }
            else if(hh == 12)
            {
                suff = "PM";
            }
            else
            {
                suff = "AM";
            }
            string time = "";

            if(hh< 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if(ss<10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            currentTime.Text = time +" " + suff;
            currentDate.Text = date;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeIN_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                clockin.Text = currentTime.Text;
                con.Open();
                sql = "insert into timeinout (emp_code, empName, time_in, date) values('" + emp_codeInput.Text + "', '"+ name.Text +"', '"+ currentTime.Text+ "', '" + currentDate.Text + "') ";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("TIMED - IN");
                    timeIN.Enabled = false;
                    timeOUT.Enabled = true;
                }



            }
        }

        private void searchEmp_Click(object sender, EventArgs e)
        {
            clockin.Text = "";
            clockout.Text = "";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlDataReader rdr;
                con.Open();
                sql = "SELECT * FROM employee WHERE emp_code='" + emp_codeInput.Text + "'";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string fullname = rdr.GetValue(1).ToString() + " " + rdr.GetValue(3).ToString() + " " + rdr.GetValue(2).ToString();
                        name.Text = fullname;
                        age.Text = rdr.GetValue(10).ToString();
                        sex.Text = rdr.GetValue(9).ToString();

                        

                    }
                    rdr.Close();

                }
                sql2 = "SELECT * FROM timeinout WHERE emp_code='" + emp_codeInput.Text + "'";
                using (MySqlCommand cmd2 = new MySqlCommand(sql2, con))
                {
                    rdr = cmd2.ExecuteReader();
                    if (rdr.Read())
                    {

                        /*string fullname = rdr.GetValue(1).ToString() + " " + rdr.GetValue(3).ToString() + " " + rdr.GetValue(2).ToString();
                        name.Text = fullname;
                        age.Text = rdr.GetValue(10).ToString();
                        sex.Text = rdr.GetValue(9).ToString();*/
                        clockin.Text = rdr.GetValue(3).ToString();
                        clockout.Text = rdr.GetValue(4).ToString();
 
                       

                        //Console.WriteLine(hrsubin, hrsubout);


                    }
                    rdr.Close();
                    if (clockin.Text == "")
                    {
                        timeIN.Enabled = true;
                    }
                    else if (clockin.Text != "")
                    {
                        timeIN.Enabled = false;
                    }
                    if (clockout.Text == "" && clockin.Text !="")
                    {
                        timeOUT.Enabled = true;
                    }

                    else if (clockout.Text != "")
                    {
                        timeOUT.Enabled = false;
                    }
                    else
                    {
                        timeIN.Enabled = true;

                    }
                }
                sql = "SELECT * FROM hrsdaysworked WHERE emp_code='" + emp_codeInput.Text + "'";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        hrsttlrender.Text = rdr.GetValue(2).ToString();
                    }
                    rdr.Close();

                }
                if (hrsttlrender.Text == "0")
                {
                    try
                    {
                        sql = "insert into hrsdaysworked (emp_code, total_hrs, total_days) values('" + emp_codeInput.Text + "' , '0' , '0') ";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.ExecuteNonQuery();
                   
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }


            }
                
            
          
        }

        private void timeOUT_Click(object sender, EventArgs e)
        {
            if (clockin.Text != "" && clockout.Text == "")
            {
                 using (MySqlConnection con = new MySqlConnection(connectionString))
                 {
                    clockout.Text = currentTime.Text;

                    string timesuffin = clockin.Text.Substring(9, 2);
                    string timesuffout = clockout.Text.Substring(9, 2);

                    if (timesuffin.Equals(timesuffout))
                    {
                        string hrsubin = clockin.Text.Substring(0, 2);
                        string hrsubout = clockout.Text.Substring(0, 2);

                        int tmrenderin = Convert.ToInt32(hrsubin);
                        int tmrenderout = Convert.ToInt32(hrsubout);
                        tmrenderall = tmrenderout - tmrenderin;
                    }
                    timerendered.Text = tmrenderall.ToString();
                    con.Open();
                    sql = "UPDATE timeinout SET time_out='" + currentTime.Text +"', hours_rendered='"+ tmrenderall +"' WHERE emp_code='" + emp_codeInput.Text + "'";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                       
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("TIMED - OUT");
                        timeOUT.Enabled = false;
                        
                        

                    }
                    int hrstotal = int.Parse(hrsttlrender.Text);
                    hrstotal += int.Parse(timerendered.Text);
                    float daystotal = 0;
                    daystotal = float.Parse(hrstotal.ToString()) / 8;

                    sql3 = "UPDATE hrsdaysworked SET total_hrs='" + hrstotal.ToString() + "', total_days='" + daystotal.ToString() + "' WHERE emp_code='" + emp_codeInput.Text + "'";
                    using (MySqlCommand cmd = new MySqlCommand(sql3, con))
                    {

                        cmd.ExecuteNonQuery();
                   
                        timeOUT.Enabled = false;



                    }
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
