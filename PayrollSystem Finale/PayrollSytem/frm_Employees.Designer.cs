namespace PayrollSytem
{
    partial class frm_Employees
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
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_OfficialFB = new System.Windows.Forms.TextBox();
            this.lblFb = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tb_ExpirationD = new System.Windows.Forms.TextBox();
            this.lblExpire = new System.Windows.Forms.Label();
            this.tb_PRC = new System.Windows.Forms.TextBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.tb_Pagibig = new System.Windows.Forms.TextBox();
            this.lblPagibig = new System.Windows.Forms.Label();
            this.tb_Tin = new System.Windows.Forms.TextBox();
            this.lblTin = new System.Windows.Forms.Label();
            this.tb_Philhealth = new System.Windows.Forms.TextBox();
            this.lblPhil = new System.Windows.Forms.Label();
            this.tb_SSS = new System.Windows.Forms.TextBox();
            this.lblSSS = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(705, 40);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 34);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(6, 56);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(92, 15);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Employee Code:";
            this.Label46.Click += new System.EventHandler(this.Label46_Click);
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(3, 80);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(836, 348);
            this.dtgemplist.TabIndex = 0;
            this.dtgemplist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgemplist_CellContentClick);
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.label1);
            this.TabPage7.Controls.Add(this.btn_edit);
            this.TabPage7.Controls.Add(this.btndelete);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(1223, 586);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "List of Employees";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.TabPage7.Click += new System.EventHandler(this.TabPage7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employees";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(570, 40);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 34);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsearch.Location = new System.Drawing.Point(104, 52);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(213, 22);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // btnempnew
            // 
            this.btnempnew.Location = new System.Drawing.Point(506, 530);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(75, 32);
            this.btnempnew.TabIndex = 21;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(296, 530);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(75, 32);
            this.btnempsave.TabIndex = 19;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(423, 97);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(283, 22);
            this.txtbplace.TabIndex = 11;
            this.txtbplace.Text = "";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(423, 25);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(283, 54);
            this.txtaddress.TabIndex = 5;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(335, 106);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(79, 13);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Place of Birth";
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(423, 132);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(121, 20);
            this.dtpdbirth.TabIndex = 10;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(335, 138);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(75, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date of Birth";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(115, 106);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(152, 20);
            this.txtlname.TabIndex = 3;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupBox9.Controls.Add(this.tb_OfficialFB);
            this.GroupBox9.Controls.Add(this.lblFb);
            this.GroupBox9.Controls.Add(this.tb_Email);
            this.GroupBox9.Controls.Add(this.lblEmail);
            this.GroupBox9.Controls.Add(this.tb_ExpirationD);
            this.GroupBox9.Controls.Add(this.lblExpire);
            this.GroupBox9.Controls.Add(this.tb_PRC);
            this.GroupBox9.Controls.Add(this.lblPrc);
            this.GroupBox9.Controls.Add(this.tb_Pagibig);
            this.GroupBox9.Controls.Add(this.lblPagibig);
            this.GroupBox9.Controls.Add(this.tb_Tin);
            this.GroupBox9.Controls.Add(this.lblTin);
            this.GroupBox9.Controls.Add(this.tb_Philhealth);
            this.GroupBox9.Controls.Add(this.lblPhil);
            this.GroupBox9.Controls.Add(this.tb_SSS);
            this.GroupBox9.Controls.Add(this.lblSSS);
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox9.Location = new System.Drawing.Point(24, 103);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(1191, 286);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Basic Information";
            this.GroupBox9.Enter += new System.EventHandler(this.GroupBox9_Enter);
            // 
            // tb_OfficialFB
            // 
            this.tb_OfficialFB.Location = new System.Drawing.Point(1044, 118);
            this.tb_OfficialFB.Margin = new System.Windows.Forms.Padding(2);
            this.tb_OfficialFB.Name = "tb_OfficialFB";
            this.tb_OfficialFB.Size = new System.Drawing.Size(104, 20);
            this.tb_OfficialFB.TabIndex = 80;
            // 
            // lblFb
            // 
            this.lblFb.AutoSize = true;
            this.lblFb.Location = new System.Drawing.Point(925, 125);
            this.lblFb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFb.Name = "lblFb";
            this.lblFb.Size = new System.Drawing.Size(105, 13);
            this.lblFb.TabIndex = 88;
            this.lblFb.Text = "Official FB Name :";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(797, 122);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(124, 20);
            this.tb_Email.TabIndex = 76;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(714, 125);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 13);
            this.lblEmail.TabIndex = 87;
            this.lblEmail.Text = "Email Address :";
            // 
            // tb_ExpirationD
            // 
            this.tb_ExpirationD.Location = new System.Drawing.Point(1044, 84);
            this.tb_ExpirationD.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ExpirationD.Name = "tb_ExpirationD";
            this.tb_ExpirationD.Size = new System.Drawing.Size(104, 20);
            this.tb_ExpirationD.TabIndex = 79;
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.Location = new System.Drawing.Point(925, 91);
            this.lblExpire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(96, 13);
            this.lblExpire.TabIndex = 86;
            this.lblExpire.Text = "Expirarion Date :";
            // 
            // tb_PRC
            // 
            this.tb_PRC.Location = new System.Drawing.Point(797, 88);
            this.tb_PRC.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PRC.Name = "tb_PRC";
            this.tb_PRC.Size = new System.Drawing.Size(124, 20);
            this.tb_PRC.TabIndex = 75;
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.Location = new System.Drawing.Point(714, 91);
            this.lblPrc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(83, 13);
            this.lblPrc.TabIndex = 85;
            this.lblPrc.Text = "PRC Number :";
            // 
            // tb_Pagibig
            // 
            this.tb_Pagibig.Location = new System.Drawing.Point(1044, 53);
            this.tb_Pagibig.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Pagibig.Name = "tb_Pagibig";
            this.tb_Pagibig.Size = new System.Drawing.Size(104, 20);
            this.tb_Pagibig.TabIndex = 78;
            // 
            // lblPagibig
            // 
            this.lblPagibig.AutoSize = true;
            this.lblPagibig.Location = new System.Drawing.Point(925, 56);
            this.lblPagibig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagibig.Name = "lblPagibig";
            this.lblPagibig.Size = new System.Drawing.Size(102, 13);
            this.lblPagibig.TabIndex = 84;
            this.lblPagibig.Text = "Pag-ibig Number :";
            // 
            // tb_Tin
            // 
            this.tb_Tin.Location = new System.Drawing.Point(797, 53);
            this.tb_Tin.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Tin.Name = "tb_Tin";
            this.tb_Tin.Size = new System.Drawing.Size(124, 20);
            this.tb_Tin.TabIndex = 74;
            // 
            // lblTin
            // 
            this.lblTin.AutoSize = true;
            this.lblTin.Location = new System.Drawing.Point(714, 56);
            this.lblTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTin.Name = "lblTin";
            this.lblTin.Size = new System.Drawing.Size(77, 13);
            this.lblTin.TabIndex = 83;
            this.lblTin.Text = "TIN Number :";
            // 
            // tb_Philhealth
            // 
            this.tb_Philhealth.Location = new System.Drawing.Point(1044, 21);
            this.tb_Philhealth.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Philhealth.Name = "tb_Philhealth";
            this.tb_Philhealth.Size = new System.Drawing.Size(104, 20);
            this.tb_Philhealth.TabIndex = 77;
            // 
            // lblPhil
            // 
            this.lblPhil.AutoSize = true;
            this.lblPhil.Location = new System.Drawing.Point(925, 25);
            this.lblPhil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhil.Name = "lblPhil";
            this.lblPhil.Size = new System.Drawing.Size(115, 13);
            this.lblPhil.TabIndex = 82;
            this.lblPhil.Text = "Philhealth Number :";
            // 
            // tb_SSS
            // 
            this.tb_SSS.Location = new System.Drawing.Point(797, 22);
            this.tb_SSS.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SSS.Name = "tb_SSS";
            this.tb_SSS.Size = new System.Drawing.Size(124, 20);
            this.tb_SSS.TabIndex = 73;
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Location = new System.Drawing.Point(711, 25);
            this.lblSSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(80, 13);
            this.lblSSS.TabIndex = 81;
            this.lblSSS.Text = "SSS Number :";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(26, 256);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(27, 13);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(115, 132);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(152, 20);
            this.txtcontact.TabIndex = 6;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(112, 253);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(58, 20);
            this.txtage.TabIndex = 12;
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(115, 28);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(152, 20);
            this.txtfname.TabIndex = 2;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(22, 230);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(26, 13);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sex";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(115, 66);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(152, 20);
            this.txtmname.TabIndex = 2;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(174, 228);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(63, 17);
            this.rdofemale.TabIndex = 9;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(115, 178);
            this.txtemerg.MaxLength = 11;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(155, 20);
            this.txtemerg.TabIndex = 13;
            this.txtemerg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemerg_KeyPress);
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(109, 230);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(51, 17);
            this.rdomale.TabIndex = 8;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(22, 138);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(93, 13);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Contact Number";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(22, 35);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(64, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "First Name";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(335, 178);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(40, 13);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Status";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Widow"});
            this.txtstatus.Location = new System.Drawing.Point(423, 175);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(121, 21);
            this.txtstatus.TabIndex = 7;
            this.txtstatus.Text = "Single";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(22, 109);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(62, 13);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Last Name";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(335, 28);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(48, 13);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Address";
            this.Label29.Click += new System.EventHandler(this.Label29_Click);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(22, 185);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(110, 26);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "Contact no.\r\n[case of emergency]";
            this.Label30.Click += new System.EventHandler(this.Label30_Click);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(22, 69);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(76, 13);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Middle Name";
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.txtpmethod.Location = new System.Drawing.Point(99, 48);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(154, 23);
            this.txtpmethod.TabIndex = 17;
            this.txtpmethod.Text = "Weekly";
            this.txtpmethod.SelectedIndexChanged += new System.EventHandler(this.txtpmethod_SelectedIndexChanged);
            // 
            // TabControl2
            // 
            this.TabControl2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1231, 612);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TabPage6.Controls.Add(this.label2);
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtcode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnew);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(1223, 586);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Employee Details";
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(400, 530);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 32);
            this.btnempupdate.TabIndex = 20;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(377, 77);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(200, 20);
            this.txtcode.TabIndex = 1;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(298, 80);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(81, 15);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Employee ID :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.cbPosition);
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox10.Location = new System.Drawing.Point(24, 413);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(1191, 111);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Work Information";
            this.GroupBox10.Enter += new System.EventHandler(this.GroupBox10_Enter);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Assistant Medical Director",
            "HRLD HEAD / OPNS MGMT Team Head",
            "EXECUTIVE ASSISTANT FOR MIS/BIOMEDICAL SERVICES",
            "SYSTEM PROGRAMMER",
            "NURSE MANAGER",
            "CHIEF MED. TECH",
            "CHIEF NURSE",
            "HRD SUPERVISOR / Quality Assurance Officer for OPNS MGMT",
            "Deputy Head -OPNS MGT. Team / Nursing Supervisor for Admin Support Operations",
            "NURSE SUPERVISOR",
            "HEAD NURSE",
            "CENTRAL RECORDS AND REGULATORY COMPLIANCE OFFICER",
            "Finance and Accounting Co-Supervisor",
            "DIALYSIS STAFF NURSE (senior)",
            "STAFF NURSE (senior)",
            "STAFF NURSE (new regular post)",
            "IMAGING SUPERVISOR",
            "BIOMED TECHNICIAN / DIALYSIS R.O. SPECIALIST",
            "STAFF NURSE (probi w/ 1 year NSA)",
            "LAB. ADMIN. OFFICER",
            "IPD HEAD PHARMACIST",
            "MIS/BIOMED STAFF/ADMIN ASSISTANT",
            "OPD HEAD PHARMACIST",
            "HEART STATION TECHNICIAN",
            "MAINTENANCE HEAD",
            "STAFF NURSE (probi w/out 1 year NSA)",
            "MED. TECH. (Regular)",
            "Purchasing Officer",
            "CUSTOMER AND SUPPORT SERVICES SUPERVISOR",
            "RADIOLOGIC TECHNOLOGIST (Senior)",
            "TAX ANALYST",
            "ACCOUNTS PAYABLE ANALYST",
            "Quality Assurance Officer for Occupational Safety",
            "CSR SUPERVISOR",
            "HLRD Team Leader",
            "OPERATION\'S COORDINATOR (Senior)",
            "HR ASSISTANT / Specialist",
            "MAINTENANCE Specialist",
            "RADIOLOGIC TECHNOLOGIST (Junior/Regular)",
            "CHIEF PHYSICAL THERAPIST",
            "BUSINESS OFFICE SUPERVISOR",
            "ULTRASOUND TECHNICIAN",
            "LEGAL LIASON/SAFETY & SANITATION OFFICER",
            "HEAD CASHIER",
            "Purchasing and Cost Control Officer",
            "HR ASSISTANT / Junior",
            "OPERATION\'S COORDINATOR (new regular)",
            "HEAD DIETICIAN",
            "MED. TECH. (Probi)",
            "HOSPITAL PHARMACIST (Regular)",
            "PHYSICAL THERAPIST (regular)",
            "Midwife/NA (Senior)",
            "Midwife/NA (Junior)",
            "IMAGING ADMIN. OFFICER",
            "INVENTORY ANALYST",
            "HIPO TEAM LEADER / ICD 10 CODER",
            "BILLING & AUDIT TEAM LEADER",
            "HIPO STAFF",
            "OPD TEAM LEADER",
            "HMO TEAM LEADER",
            "EEG TECHNICIAN",
            "RESPIRATORY THERAPIST (UNDERBOARD)",
            "PHYSICAL THERAPIST (probi)",
            "GENERAL ACCOUNTING CLERK",
            "ACCOUNTS RECEIVABLE ANALYST",
            "Customer Service Associate",
            "OFFICE STAFF/ASST. MED. DIR.",
            "BILLING & AUDIT STAFF",
            "HIPO STAFF",
            "CASHIER STAFF",
            "CSR ASSISTANT (Regular)",
            "HMO/OPD STAFF",
            "MEDICAL RECORDS STAFF",
            "PHARMACY ASST. (regular)",
            "NURSING ASSISTANT (Women\'s Health)",
            "APPLICATION SPECIALIST (probi)",
            "DRIVER/VEHICLE MAINTENANCE",
            "WARD CLERK",
            "NURSING ASSISTANT (Regular)",
            "NURSING ASSISTANT (probi)",
            "DRIVER",
            "LIAISON OFFICER/MAINTENANCE STAFF",
            "LIASON OFFICER",
            "DIETARY COOK",
            "SECURITY GUARD (Regular)",
            "LAB ENCODER (Regular)",
            "TEAM LEADER LINEN/LAUNDRY/ELEVATOR",
            "ORDERLY STAFF (senior)",
            "CSR ASSISTANT (probi)",
            "FOOD SERVER",
            "LINEN/TRIAGE STAFF",
            "LAUNDRY STAFF",
            "MAINTENANCE STAFF (probi)",
            "SECURITY GUARD (probi)",
            "ORDERLY/TECHNICIAN",
            "ORDERLY STAFF"});
            this.cbPosition.Location = new System.Drawing.Point(347, 18);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(492, 23);
            this.cbPosition.TabIndex = 19;
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "Active",
            "Resigned",
            "Retired"});
            this.txtworkstatus.Location = new System.Drawing.Point(349, 45);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(154, 23);
            this.txtworkstatus.TabIndex = 18;
            this.txtworkstatus.Text = "Active";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(22, 22);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(71, 15);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "Daily Rate :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(282, 21);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(59, 15);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Position :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(292, 48);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(49, 15);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "Status :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(14, 50);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(77, 15);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Pay Method :";
            this.Label34.Click += new System.EventHandler(this.Label34_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(845, 21);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(73, 15);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date Hired :";
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(99, 18);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(154, 22);
            this.txtdrate.TabIndex = 14;
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(924, 18);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(154, 22);
            this.dtpdhired.TabIndex = 16;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 612);
            this.Controls.Add(this.TabControl2);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TabPage TabPage7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_OfficialFB;
        private System.Windows.Forms.Label lblFb;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tb_ExpirationD;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.TextBox tb_PRC;
        private System.Windows.Forms.Label lblPrc;
        private System.Windows.Forms.TextBox tb_Pagibig;
        private System.Windows.Forms.Label lblPagibig;
        private System.Windows.Forms.TextBox tb_Tin;
        private System.Windows.Forms.Label lblTin;
        private System.Windows.Forms.TextBox tb_Philhealth;
        private System.Windows.Forms.Label lblPhil;
        private System.Windows.Forms.TextBox tb_SSS;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}