using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;user id=root;database=payroll";
        public Form1()
        {
            InitializeComponent();
            load_employee_data();
        }
        MySqlDataAdapter mySqlData = new MySqlDataAdapter();
        private void Save_Click(object sender, EventArgs e)
        {

            string lastName = lastnameField.Text.Trim();
            string firstName = firstnameField.Text.Trim();
            string middleName = middlenameFIeld.Text.Trim();
            string position = positionFIeld.Text.Trim(); ;
            decimal rate = 0;
            int hrs_worked = 0;
            string status = statusDrop.Text.Trim();
            if (lastName != "" && firstName != "" && middleName != "" && position != "" && status != "")
            {
                try
                {
                    rate = Convert.ToDecimal(rateFIeld.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data entered in Rate must be Numerical.");
                    rateFIeld.Text = "";
                    rateFIeld.Focus();
                    return;
                }
                try
                {
                    hrs_worked = Convert.ToInt32(hoursworkedField.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data entered in Hours worked must be Numerical.");
                    hoursworkedField.Text = "";
                    hoursworkedField.Focus();
                    return;
                }
            
                status = status.Substring(0, 1);
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string sql = "insert into  (lastname, firstname, middlename, position, rate, hours_worked, status) values ('" + lastName + "' , '" + firstName + "', " +
                            "'" + middleName + "','" + position + "', " + rate + ", " + hrs_worked + ", '" + status + "')";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Saved Successfully");

                            lastnameField.Text = "";
                            firstnameField.Text = "";
                            middlenameFIeld.Text = "";
                            positionFIeld.Text = "";
                            rateFIeld.Text = "";
                            hoursworkedField.Text = "";
                            lastnameField.Focus();
                            load_employee_data();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Unsuccessful");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the necessaryfields marked (*).");
            }
        }

        private void load_employee_data()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "select * from employee order by idno";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    MySqlDataAdapter mySqlData = new MySqlDataAdapter();
                    mySqlData.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    mySqlData.Fill(dt);

                    EmployeeDataSheet.DataSource = dt;

                    lastnameField.Text = "";
                    firstnameField.Text = "";
                    middlenameFIeld.Text = "";
                    positionFIeld.Text = "";
                    rateFIeld.Text = "";
                    hoursworkedField.Text = "";
                    lastnameField.Focus();
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "DELETE FROM employee where idno="+EmployeeDataSheet.CurrentRow.Cells[0].Value.ToString()+"";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {

                    cmd.ExecuteNonQuery();

                    load_employee_data();
                }

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string columnName = EmployeeDataSheet.CurrentCell.OwningColumn.Name;
            string setVal = "";
            if (columnName.Equals("firstname"))
            {
                setVal = firstnameField.Text;

            }
            else if (columnName.Equals("lastname"))
            {
                setVal = lastnameField.Text;

            }
            else if (columnName.Equals("middlename"))
            {
                setVal = middlenameFIeld.Text;

            }
            else if (columnName.Equals("position"))
            {
                setVal = positionFIeld.Text;

            }
            else if (columnName.Equals("rate"))
            {
                setVal = rateFIeld.Text;

            }
            else if (columnName.Equals("hours_worked"))
            {
                setVal = hoursworkedField.Text;

            }
            else if (columnName.Equals("status"))
            {
                setVal = statusDrop.Text;

            }
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                
                string sql = "UPDATE employee SET "+ columnName+"='"+ setVal +"' WHERE idno="+ EmployeeDataSheet.CurrentRow.Cells[0].Value.ToString() + "";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                    load_employee_data();
                    
                }

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string columnName = EmployeeDataSheet.CurrentCell.OwningColumn.Name;
            string selectedVal = EmployeeDataSheet.CurrentCell.Value.ToString();

            if (columnName.Equals("firstname"))
            {
                firstnameField.Text = selectedVal;
                lastnameField.Text = "";
                middlenameFIeld.Text = "";
                positionFIeld.Text = "";
                rateFIeld.Text = "";
                hoursworkedField.Text = "";
            }
            else if (columnName.Equals("lastname"))
            {
                lastnameField.Text = selectedVal;
                firstnameField.Text = "";
                middlenameFIeld.Text = "";
                positionFIeld.Text = "";
                rateFIeld.Text = "";
                hoursworkedField.Text = "";
            }
            else if (columnName.Equals("middlename"))
            {
                middlenameFIeld.Text = selectedVal;
                lastnameField.Text = "";
                firstnameField.Text = "";
                positionFIeld.Text = "";
                rateFIeld.Text = "";
                hoursworkedField.Text = "";
            }
            else if (columnName.Equals("position"))
            {
                positionFIeld.Text = selectedVal;
                lastnameField.Text = "";
                firstnameField.Text = "";
                middlenameFIeld.Text = "";
                rateFIeld.Text = "";
                hoursworkedField.Text = "";
            }
            else if (columnName.Equals("rate"))
            {
                rateFIeld.Text = selectedVal;
                lastnameField.Text = "";
                firstnameField.Text = "";
                middlenameFIeld.Text = "";
                positionFIeld.Text = "";
                hoursworkedField.Text = "";
            }
            else if (columnName.Equals("hours_worked"))
            {
                hoursworkedField.Text = selectedVal;
                lastnameField.Text = "";
                firstnameField.Text = "";
                middlenameFIeld.Text = "";
                positionFIeld.Text = "";
                rateFIeld.Text = "";
            }
            else if (columnName.Equals("status"))
            {
                statusDrop.Text = selectedVal;
                lastnameField.Text = "";
                firstnameField.Text = "";
                middlenameFIeld.Text = "";
                positionFIeld.Text = "";
                rateFIeld.Text = "";
                hoursworkedField.Text = "";
            }
        }
    }
}
