﻿using System;
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
    public partial class frm_reports : Form
    {
        public frm_reports()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;
        private void reports(string sql,string rptname)
        {

          
           

        }

        private void btnweeklypayroll_Click(object sender, EventArgs e)
        {
            reports("SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ),`num_days` ,  `d_rate` ,  `r_wage` ,  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` ,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  `ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued` " 
           + "FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od " 
           + "WHERE e.`emp_code` = p.`emp_code` "
           + "AND p.`emp_code` = we.`emp_code` " 
           + "AND p.`trans_id` = od.`trans_id` ", "weeklypayroll");
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            sql = "SELECT CONCAT(  `emp_lname` ,  ' , ',  `emp_fname` ) ,`num_days` , `d_rate` ,  `r_wage` "
               + ",  `overtime` , `hol_pay` ,  `gross_sal` ,  `cash_ad` ,  `bread_vale` ,  `philhealth` , "
               + "`pag-ibig`,  `deduct1` ,  `ded_amount1` , `deduct2` ,  `ded_amount2` ,  `deduct3` ,  "
               + "`ded_amount3` ,  `total_ded` ,  `net_income` ,`dateissued`" +
                " FROM  `employee` e,  `employee_workinfo` we,  `payroll` p,  `other_deduction` od " +
                " WHERE e.`emp_code` = p.`emp_code` " +
                " AND p.`emp_code` = we.`emp_code` " +
                " AND p.`trans_id` = od.`trans_id` ";
            reports(sql, "payslip");

              
        }
    }
}
