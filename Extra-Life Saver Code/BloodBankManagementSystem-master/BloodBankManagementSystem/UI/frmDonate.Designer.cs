namespace BloodBankManagementSystem.UI
{
    partial class frmDonate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonate));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvDonate = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbdonorGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtdonorAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtdonorContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtdonorLastName = new System.Windows.Forms.TextBox();
            this.txtdonorEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.lblDonorID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxProfilePictureDonor = new System.Windows.Forms.PictureBox();
            this.lblProfilePicture = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbdonatetogender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdonatetoaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdonatetocontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdonatetolastname = new System.Windows.Forms.TextBox();
            this.txtdonatetoemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdonatetoid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdonatetofirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btndonatetoselectimage = new System.Windows.Forms.Button();
            this.pictureBoxdonateto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SelectBloodGroupcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectDonorNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdonorfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdonatetoquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePictureDonor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdonateto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(343, 496);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(429, 25);
            this.txtSearch.TabIndex = 75;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(296, 502);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 74;
            this.lblSearch.Text = "Search";
            // 
            // dgvDonate
            // 
            this.dgvDonate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonate.Location = new System.Drawing.Point(34, 537);
            this.dgvDonate.Name = "dgvDonate";
            this.dgvDonate.Size = new System.Drawing.Size(1004, 126);
            this.dgvDonate.TabIndex = 73;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(598, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 42);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(484, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 42);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(369, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1030, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(479, 6);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(135, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Donate Blood";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Salmon;
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.lblFormTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1069, 40);
            this.panelTop.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbdonorGender);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtdonorAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtdonorContact);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.txtdonorLastName);
            this.groupBox1.Controls.Add(this.txtdonorEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtDonorID);
            this.groupBox1.Controls.Add(this.lblDonorID);
            this.groupBox1.Controls.Add(this.txtdonorfirstname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.pictureBoxProfilePictureDonor);
            this.groupBox1.Controls.Add(this.lblProfilePicture);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 342);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donor";
            // 
            // cmbdonorGender
            // 
            this.cmbdonorGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdonorGender.FormattingEnabled = true;
            this.cmbdonorGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbdonorGender.Location = new System.Drawing.Point(328, 185);
            this.cmbdonorGender.Name = "cmbdonorGender";
            this.cmbdonorGender.Size = new System.Drawing.Size(165, 25);
            this.cmbdonorGender.TabIndex = 84;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(267, 191);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 96;
            this.lblGender.Text = "Gender";
            // 
            // txtdonorAddress
            // 
            this.txtdonorAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonorAddress.Location = new System.Drawing.Point(90, 252);
            this.txtdonorAddress.Multiline = true;
            this.txtdonorAddress.Name = "txtdonorAddress";
            this.txtdonorAddress.Size = new System.Drawing.Size(403, 79);
            this.txtdonorAddress.TabIndex = 87;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(36, 277);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 95;
            this.lblAddress.Text = "Address";
            // 
            // txtdonorContact
            // 
            this.txtdonorContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonorContact.Location = new System.Drawing.Point(93, 221);
            this.txtdonorContact.MaxLength = 15;
            this.txtdonorContact.Name = "txtdonorContact";
            this.txtdonorContact.Size = new System.Drawing.Size(400, 25);
            this.txtdonorContact.TabIndex = 86;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(29, 233);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(47, 13);
            this.lblContact.TabIndex = 94;
            this.lblContact.Text = "Contact";
            // 
            // txtdonorLastName
            // 
            this.txtdonorLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonorLastName.Location = new System.Drawing.Point(328, 153);
            this.txtdonorLastName.Name = "txtdonorLastName";
            this.txtdonorLastName.Size = new System.Drawing.Size(165, 25);
            this.txtdonorLastName.TabIndex = 82;
            // 
            // txtdonorEmail
            // 
            this.txtdonorEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonorEmail.Location = new System.Drawing.Point(92, 187);
            this.txtdonorEmail.Name = "txtdonorEmail";
            this.txtdonorEmail.Size = new System.Drawing.Size(165, 25);
            this.txtdonorEmail.TabIndex = 83;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 92;
            this.lblEmail.Text = "Email";
            // 
            // txtDonorID
            // 
            this.txtDonorID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorID.Location = new System.Drawing.Point(93, 123);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.ReadOnly = true;
            this.txtDonorID.Size = new System.Drawing.Size(400, 25);
            this.txtDonorID.TabIndex = 80;
            this.txtDonorID.TabStop = false;
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorID.Location = new System.Drawing.Point(26, 129);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(54, 13);
            this.lblDonorID.TabIndex = 91;
            this.lblDonorID.Text = "Donor ID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(873, 60);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(165, 25);
            this.txtQuantity.TabIndex = 81;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(816, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblFirstName.TabIndex = 90;
            this.lblFirstName.Text = "Quantity";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Location = new System.Drawing.Point(206, 75);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(116, 32);
            this.btnSelectImage.TabIndex = 79;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfilePictureDonor
            // 
            this.pictureBoxProfilePictureDonor.Location = new System.Drawing.Point(93, 28);
            this.pictureBoxProfilePictureDonor.Name = "pictureBoxProfilePictureDonor";
            this.pictureBoxProfilePictureDonor.Size = new System.Drawing.Size(100, 89);
            this.pictureBoxProfilePictureDonor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePictureDonor.TabIndex = 89;
            this.pictureBoxProfilePictureDonor.TabStop = false;
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilePicture.Location = new System.Drawing.Point(9, 75);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(78, 13);
            this.lblProfilePicture.TabIndex = 88;
            this.lblProfilePicture.Text = "Profile Picture";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(263, 160);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 93;
            this.lblLastName.Text = "Last Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbdonatetogender);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtdonatetoaddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtdonatetoquantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtdonatetocontact);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdonatetolastname);
            this.groupBox2.Controls.Add(this.txtdonatetoemail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdonatetoid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtdonatetofirstname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btndonatetoselectimage);
            this.groupBox2.Controls.Add(this.pictureBoxdonateto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(539, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 342);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donate To";
            // 
            // cmbdonatetogender
            // 
            this.cmbdonatetogender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdonatetogender.FormattingEnabled = true;
            this.cmbdonatetogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbdonatetogender.Location = new System.Drawing.Point(328, 185);
            this.cmbdonatetogender.Name = "cmbdonatetogender";
            this.cmbdonatetogender.Size = new System.Drawing.Size(165, 25);
            this.cmbdonatetogender.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Gender";
            // 
            // txtdonatetoaddress
            // 
            this.txtdonatetoaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetoaddress.Location = new System.Drawing.Point(90, 252);
            this.txtdonatetoaddress.Multiline = true;
            this.txtdonatetoaddress.Name = "txtdonatetoaddress";
            this.txtdonatetoaddress.Size = new System.Drawing.Size(403, 79);
            this.txtdonatetoaddress.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Address";
            // 
            // txtdonatetocontact
            // 
            this.txtdonatetocontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetocontact.Location = new System.Drawing.Point(93, 221);
            this.txtdonatetocontact.MaxLength = 15;
            this.txtdonatetocontact.Name = "txtdonatetocontact";
            this.txtdonatetocontact.Size = new System.Drawing.Size(165, 25);
            this.txtdonatetocontact.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Contact";
            // 
            // txtdonatetolastname
            // 
            this.txtdonatetolastname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetolastname.Location = new System.Drawing.Point(328, 151);
            this.txtdonatetolastname.Name = "txtdonatetolastname";
            this.txtdonatetolastname.Size = new System.Drawing.Size(165, 25);
            this.txtdonatetolastname.TabIndex = 82;
            // 
            // txtdonatetoemail
            // 
            this.txtdonatetoemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetoemail.Location = new System.Drawing.Point(92, 187);
            this.txtdonatetoemail.Name = "txtdonatetoemail";
            this.txtdonatetoemail.Size = new System.Drawing.Size(165, 25);
            this.txtdonatetoemail.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Email";
            // 
            // txtdonatetoid
            // 
            this.txtdonatetoid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetoid.Location = new System.Drawing.Point(93, 123);
            this.txtdonatetoid.Name = "txtdonatetoid";
            this.txtdonatetoid.ReadOnly = true;
            this.txtdonatetoid.Size = new System.Drawing.Size(400, 25);
            this.txtdonatetoid.TabIndex = 80;
            this.txtdonatetoid.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Donate ID";
            // 
            // txtdonatetofirstname
            // 
            this.txtdonatetofirstname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetofirstname.Location = new System.Drawing.Point(93, 154);
            this.txtdonatetofirstname.Name = "txtdonatetofirstname";
            this.txtdonatetofirstname.Size = new System.Drawing.Size(165, 25);
            this.txtdonatetofirstname.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "First Name";
            // 
            // btndonatetoselectimage
            // 
            this.btndonatetoselectimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndonatetoselectimage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndonatetoselectimage.Location = new System.Drawing.Point(206, 75);
            this.btndonatetoselectimage.Name = "btndonatetoselectimage";
            this.btndonatetoselectimage.Size = new System.Drawing.Size(116, 32);
            this.btndonatetoselectimage.TabIndex = 79;
            this.btndonatetoselectimage.Text = "Select Image";
            this.btndonatetoselectimage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxdonateto
            // 
            this.pictureBoxdonateto.Location = new System.Drawing.Point(93, 28);
            this.pictureBoxdonateto.Name = "pictureBoxdonateto";
            this.pictureBoxdonateto.Size = new System.Drawing.Size(100, 89);
            this.pictureBoxdonateto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxdonateto.TabIndex = 89;
            this.pictureBoxdonateto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Profile Picture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Last Name";
            // 
            // SelectBloodGroupcomboBox
            // 
            this.SelectBloodGroupcomboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBloodGroupcomboBox.FormattingEnabled = true;
            this.SelectBloodGroupcomboBox.Location = new System.Drawing.Point(215, 60);
            this.SelectBloodGroupcomboBox.Name = "SelectBloodGroupcomboBox";
            this.SelectBloodGroupcomboBox.Size = new System.Drawing.Size(165, 25);
            this.SelectBloodGroupcomboBox.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Select Blood Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Select Donor Name";
            // 
            // SelectDonorNamecomboBox
            // 
            this.SelectDonorNamecomboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDonorNamecomboBox.FormattingEnabled = true;
            this.SelectDonorNamecomboBox.Location = new System.Drawing.Point(511, 60);
            this.SelectDonorNamecomboBox.Name = "SelectDonorNamecomboBox";
            this.SelectDonorNamecomboBox.Size = new System.Drawing.Size(165, 25);
            this.SelectDonorNamecomboBox.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "First Name";
            // 
            // txtdonorfirstname
            // 
            this.txtdonorfirstname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonorfirstname.Location = new System.Drawing.Point(93, 153);
            this.txtdonorfirstname.Name = "txtdonorfirstname";
            this.txtdonorfirstname.Size = new System.Drawing.Size(165, 25);
            this.txtdonorfirstname.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Quantity";
            // 
            // txtdonatetoquantity
            // 
            this.txtdonatetoquantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonatetoquantity.Location = new System.Drawing.Point(328, 221);
            this.txtdonatetoquantity.MaxLength = 15;
            this.txtdonatetoquantity.Name = "txtdonatetoquantity";
            this.txtdonatetoquantity.Size = new System.Drawing.Size(165, 25);
            this.txtdonatetoquantity.TabIndex = 86;
            // 
            // frmDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1069, 675);
            this.Controls.Add(this.SelectDonorNamecomboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SelectBloodGroupcomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonate";
            this.Load += new System.EventHandler(this.frmDonate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePictureDonor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdonateto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvDonate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbdonorGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtdonorAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtdonorContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtdonorLastName;
        private System.Windows.Forms.TextBox txtdonorEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.Label lblDonorID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pictureBoxProfilePictureDonor;
        private System.Windows.Forms.Label lblProfilePicture;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbdonatetogender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdonatetoaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdonatetocontact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdonatetolastname;
        private System.Windows.Forms.TextBox txtdonatetoemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdonatetoid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdonatetofirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndonatetoselectimage;
        private System.Windows.Forms.PictureBox pictureBoxdonateto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SelectBloodGroupcomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SelectDonorNamecomboBox;
        private System.Windows.Forms.TextBox txtdonorfirstname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdonatetoquantity;
        private System.Windows.Forms.Label label1;
    }
}