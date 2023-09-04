namespace ContactForm
{
    partial class FormBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            pictureBox1 = new PictureBox();
            lblFirstName = new Label();
            txtboxFirstName = new TextBox();
            txtboxMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtboxLastName = new TextBox();
            lblLastName = new Label();
            txtboxAddress = new TextBox();
            lblAddress = new Label();
            txtboxContactNo = new TextBox();
            lblContactNo = new Label();
            lblGender = new Label();
            cmbboxGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtboxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.BorderStyle = BorderStyle.Fixed3D;
            lblFirstName.Location = new Point(36, 165);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(99, 27);
            lblFirstName.TabIndex = 1;
            lblFirstName.Tag = "lblFirstNameID";
            lblFirstName.Text = "First Name";
            lblFirstName.Click += label1_Click;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(214, 165);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(150, 31);
            txtboxFirstName.TabIndex = 2;
            txtboxFirstName.Tag = "FirstNameID";
            txtboxFirstName.Text = "First Name";
            txtboxFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtboxMiddleName
            // 
            txtboxMiddleName.Location = new Point(214, 215);
            txtboxMiddleName.Name = "txtboxMiddleName";
            txtboxMiddleName.Size = new Size(150, 31);
            txtboxMiddleName.TabIndex = 4;
            txtboxMiddleName.Tag = "MiddleNameID";
            txtboxMiddleName.Text = "Middle Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.BorderStyle = BorderStyle.Fixed3D;
            lblMiddleName.Location = new Point(36, 215);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(121, 27);
            lblMiddleName.TabIndex = 3;
            lblMiddleName.Tag = "lblMiddleNameID";
            lblMiddleName.Text = "Middle Name";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(214, 267);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(150, 31);
            txtboxLastName.TabIndex = 6;
            txtboxLastName.Tag = "LastNameID";
            txtboxLastName.Text = "Last Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.BorderStyle = BorderStyle.Fixed3D;
            lblLastName.Location = new Point(36, 267);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(97, 27);
            lblLastName.TabIndex = 5;
            lblLastName.Tag = "lblLastNameID";
            lblLastName.Text = "Last Name";
            lblLastName.Click += label2_Click;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(214, 319);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(150, 31);
            txtboxAddress.TabIndex = 8;
            txtboxAddress.Tag = "AddressID";
            txtboxAddress.Text = "Address";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.BorderStyle = BorderStyle.Fixed3D;
            lblAddress.Location = new Point(36, 319);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 27);
            lblAddress.TabIndex = 7;
            lblAddress.Tag = "lblAddressID";
            lblAddress.Text = "Address";
            // 
            // txtboxContactNo
            // 
            txtboxContactNo.Location = new Point(214, 370);
            txtboxContactNo.Name = "txtboxContactNo";
            txtboxContactNo.Size = new Size(150, 31);
            txtboxContactNo.TabIndex = 10;
            txtboxContactNo.Tag = "ContactNoID";
            txtboxContactNo.Text = "Contact No.";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.BackColor = Color.Transparent;
            lblContactNo.BorderStyle = BorderStyle.Fixed3D;
            lblContactNo.Location = new Point(36, 370);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(108, 27);
            lblContactNo.TabIndex = 9;
            lblContactNo.Tag = "lblContactNoID";
            lblContactNo.Text = "Contact No.";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.BorderStyle = BorderStyle.Fixed3D;
            lblGender.Location = new Point(36, 425);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(71, 27);
            lblGender.TabIndex = 11;
            lblGender.Tag = "lblGenderID";
            lblGender.Text = "Gender";
            // 
            // cmbboxGender
            // 
            cmbboxGender.FormattingEnabled = true;
            cmbboxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbboxGender.Location = new Point(214, 425);
            cmbboxGender.Name = "cmbboxGender";
            cmbboxGender.Size = new Size(182, 33);
            cmbboxGender.TabIndex = 17;
            cmbboxGender.Text = "Gender";
            cmbboxGender.SelectedIndexChanged += cmbboxGender_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.Location = new Point(1026, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 53);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Location = new Point(1026, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 53);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(1026, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 53);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Cornsilk;
            btnClear.Location = new Point(1026, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 53);
            btnClear.TabIndex = 21;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(456, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(483, 297);
            dataGridView1.TabIndex = 22;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Location = new Point(461, 121);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 23;
            lblSearch.Tag = "lblSearchID";
            lblSearch.Text = "Search";
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(558, 121);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(381, 31);
            txtboxSearch.TabIndex = 24;
            txtboxSearch.Tag = "SearchID";
            txtboxSearch.Text = "Search";
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 503);
            Controls.Add(txtboxSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbboxGender);
            Controls.Add(lblGender);
            Controls.Add(txtboxContactNo);
            Controls.Add(lblContactNo);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtboxMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(pictureBox1);
            Name = "FormBase";
            Text = "EContacts";
            Load += FormBase_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblFirstName;
        private TextBox txtboxFirstName;
        private TextBox txtboxMiddleName;
        private Label lblMiddleName;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private TextBox txtboxContactNo;
        private Label lblContactNo;
        private Label lblGender;
        private ComboBox cmbboxGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtboxSearch;
    }
}