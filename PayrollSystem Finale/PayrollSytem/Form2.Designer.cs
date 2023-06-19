
namespace PayrollSytem
{
    partial class frm_TiTo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentTime = new System.Windows.Forms.Label();
            this.emp_codeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeIN = new System.Windows.Forms.Button();
            this.timeOUT = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.hrsrender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clockin = new System.Windows.Forms.Label();
            this.clockout = new System.Windows.Forms.Label();
            this.timerendered = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hrsttlrender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.Color.Red;
            this.currentTime.Location = new System.Drawing.Point(103, 48);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(120, 25);
            this.currentTime.TabIndex = 0;
            this.currentTime.Text = "00 : 00 : 00";
            this.currentTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // emp_codeInput
            // 
            this.emp_codeInput.Location = new System.Drawing.Point(349, 98);
            this.emp_codeInput.Name = "emp_codeInput";
            this.emp_codeInput.Size = new System.Drawing.Size(180, 20);
            this.emp_codeInput.TabIndex = 2;
            this.emp_codeInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPLOYEE ID";
            // 
            // searchEmp
            // 
            this.searchEmp.Location = new System.Drawing.Point(388, 124);
            this.searchEmp.Name = "searchEmp";
            this.searchEmp.Size = new System.Drawing.Size(75, 23);
            this.searchEmp.TabIndex = 4;
            this.searchEmp.Text = "Search";
            this.searchEmp.UseVisualStyleBackColor = true;
            this.searchEmp.Click += new System.EventHandler(this.searchEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hours Rendered :";
            // 
            // timeIN
            // 
            this.timeIN.Enabled = false;
            this.timeIN.Location = new System.Drawing.Point(228, 345);
            this.timeIN.Name = "timeIN";
            this.timeIN.Size = new System.Drawing.Size(75, 23);
            this.timeIN.TabIndex = 9;
            this.timeIN.Text = "TIME IN";
            this.timeIN.UseVisualStyleBackColor = true;
            this.timeIN.Click += new System.EventHandler(this.timeIN_Click);
            // 
            // timeOUT
            // 
            this.timeOUT.Enabled = false;
            this.timeOUT.Location = new System.Drawing.Point(514, 345);
            this.timeOUT.Name = "timeOUT";
            this.timeOUT.Size = new System.Drawing.Size(75, 23);
            this.timeOUT.TabIndex = 10;
            this.timeOUT.Text = "TIME OUT";
            this.timeOUT.UseVisualStyleBackColor = true;
            this.timeOUT.Click += new System.EventHandler(this.timeOUT_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(228, 186);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 11;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(228, 214);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(0, 13);
            this.sex.TabIndex = 12;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(228, 243);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(0, 13);
            this.age.TabIndex = 13;
            // 
            // hrsrender
            // 
            this.hrsrender.AutoSize = true;
            this.hrsrender.Location = new System.Drawing.Point(269, 270);
            this.hrsrender.Name = "hrsrender";
            this.hrsrender.Size = new System.Drawing.Size(0, 13);
            this.hrsrender.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollSytem.Properties.Resources.datetime;
            this.pictureBox1.Location = new System.Drawing.Point(43, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(103, 73);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(127, 20);
            this.currentDate.TabIndex = 15;
            this.currentDate.Text = "MM / DD / YYYY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Time In : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time Out :";
            // 
            // clockin
            // 
            this.clockin.AutoSize = true;
            this.clockin.Location = new System.Drawing.Point(585, 186);
            this.clockin.Name = "clockin";
            this.clockin.Size = new System.Drawing.Size(0, 13);
            this.clockin.TabIndex = 18;
            // 
            // clockout
            // 
            this.clockout.AutoSize = true;
            this.clockout.Location = new System.Drawing.Point(585, 214);
            this.clockout.Name = "clockout";
            this.clockout.Size = new System.Drawing.Size(0, 13);
            this.clockout.TabIndex = 19;
            // 
            // timerendered
            // 
            this.timerendered.AutoSize = true;
            this.timerendered.Location = new System.Drawing.Point(585, 243);
            this.timerendered.Name = "timerendered";
            this.timerendered.Size = new System.Drawing.Size(27, 13);
            this.timerendered.TabIndex = 20;
            this.timerendered.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total Rendered :";
            // 
            // hrsttlrender
            // 
            this.hrsttlrender.AutoSize = true;
            this.hrsttlrender.Location = new System.Drawing.Point(585, 270);
            this.hrsttlrender.Name = "hrsttlrender";
            this.hrsttlrender.Size = new System.Drawing.Size(13, 13);
            this.hrsttlrender.TabIndex = 22;
            this.hrsttlrender.Text = "0";
            // 
            // frm_TiTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hrsttlrender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timerendered);
            this.Controls.Add(this.clockout);
            this.Controls.Add(this.clockin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.hrsrender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.name);
            this.Controls.Add(this.timeOUT);
            this.Controls.Add(this.timeIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_codeInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentTime);
            this.Name = "frm_TiTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time-IN / Time OUT";
            this.Load += new System.EventHandler(this.frm_TiTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emp_codeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button timeIN;
        private System.Windows.Forms.Button timeOUT;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label hrsrender;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label clockin;
        private System.Windows.Forms.Label clockout;
        private System.Windows.Forms.Label timerendered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label hrsttlrender;
    }
}