namespace BJM.BankingApp.UI
{
    partial class Main
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
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lblIDDisplay = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAgeDisplay = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.lblDeposits = new System.Windows.Forms.Label();
            this.lblWithdrawals = new System.Windows.Forms.Label();
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnLoadXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 15;
            this.lbxCustomers.Location = new System.Drawing.Point(13, 13);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(227, 184);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // lblIDDisplay
            // 
            this.lblIDDisplay.AutoSize = true;
            this.lblIDDisplay.Location = new System.Drawing.Point(246, 13);
            this.lblIDDisplay.Name = "lblIDDisplay";
            this.lblIDDisplay.Size = new System.Drawing.Size(21, 15);
            this.lblIDDisplay.TabIndex = 1;
            this.lblIDDisplay.Text = "ID:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(246, 41);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(67, 15);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "First Name:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(246, 69);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(66, 15);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last Name:";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(246, 97);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(31, 15);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(246, 125);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(62, 15);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblAgeDisplay
            // 
            this.lblAgeDisplay.AutoSize = true;
            this.lblAgeDisplay.Location = new System.Drawing.Point(246, 153);
            this.lblAgeDisplay.Name = "lblAgeDisplay";
            this.lblAgeDisplay.Size = new System.Drawing.Size(31, 15);
            this.lblAgeDisplay.TabIndex = 6;
            this.lblAgeDisplay.Text = "Age:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(321, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 15);
            this.lblID.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(321, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 15);
            this.lblAge.TabIndex = 8;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(321, 38);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(100, 23);
            this.txtfName.TabIndex = 9;
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(321, 66);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(100, 23);
            this.txtlName.TabIndex = 10;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(321, 94);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 23);
            this.txtSSN.TabIndex = 11;
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(321, 122);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.Size = new System.Drawing.Size(100, 23);
            this.txtBDate.TabIndex = 12;
            // 
            // lblDeposits
            // 
            this.lblDeposits.AutoSize = true;
            this.lblDeposits.Location = new System.Drawing.Point(12, 197);
            this.lblDeposits.Name = "lblDeposits";
            this.lblDeposits.Size = new System.Drawing.Size(55, 15);
            this.lblDeposits.TabIndex = 13;
            this.lblDeposits.Text = "Deposits:";
            // 
            // lblWithdrawals
            // 
            this.lblWithdrawals.AutoSize = true;
            this.lblWithdrawals.Location = new System.Drawing.Point(13, 302);
            this.lblWithdrawals.Name = "lblWithdrawals";
            this.lblWithdrawals.Size = new System.Drawing.Size(75, 15);
            this.lblWithdrawals.TabIndex = 14;
            this.lblWithdrawals.Text = "Withdrawals:";
            // 
            // dgvDeposits
            // 
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.Location = new System.Drawing.Point(12, 215);
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.RowTemplate.Height = 25;
            this.dgvDeposits.Size = new System.Drawing.Size(408, 84);
            this.dgvDeposits.TabIndex = 15;
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.Location = new System.Drawing.Point(12, 320);
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.RowTemplate.Height = 25;
            this.dgvWithdrawals.Size = new System.Drawing.Size(408, 84);
            this.dgvWithdrawals.TabIndex = 16;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(242, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(303, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(12, 410);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(100, 23);
            this.btnSaveXML.TabIndex = 20;
            this.btnSaveXML.Text = "Save to XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(118, 410);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(100, 23);
            this.btnLoadXML.TabIndex = 21;
            this.btnLoadXML.Text = "Load from XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 439);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Controls.Add(this.lblWithdrawals);
            this.Controls.Add(this.lblDeposits);
            this.Controls.Add(this.txtBDate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAgeDisplay);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblIDDisplay);
            this.Controls.Add(this.lbxCustomers);
            this.Name = "Main";
            this.Text = "Banking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxCustomers;
        private Label lblIDDisplay;
        private Label lblFname;
        private Label lblLname;
        private Label lblSSN;
        private Label lblBirthDate;
        private Label lblAgeDisplay;
        private Label lblID;
        private Label lblAge;
        private TextBox txtfName;
        private TextBox txtlName;
        private TextBox txtSSN;
        private TextBox txtBDate;
        private Label lblDeposits;
        private Label lblWithdrawals;
        private DataGridView dgvDeposits;
        private DataGridView dgvWithdrawals;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSaveXML;
        private Button btnLoadXML;
    }
}