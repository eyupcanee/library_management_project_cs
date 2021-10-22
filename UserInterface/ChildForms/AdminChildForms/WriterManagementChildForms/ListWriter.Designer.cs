
namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    partial class ListWriter
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
            this.dgvWriters = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbConfirmation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.btnListAll = new FontAwesome.Sharp.IconButton();
            this.btnListByStatus = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnListByConfirmation = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWriters
            // 
            this.dgvWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWriters.Location = new System.Drawing.Point(0, 0);
            this.dgvWriters.Name = "dgvWriters";
            this.dgvWriters.RowTemplate.Height = 25;
            this.dgvWriters.Size = new System.Drawing.Size(919, 322);
            this.dgvWriters.TabIndex = 0;
            this.dgvWriters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWriters_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvWriters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 322);
            this.panel1.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 25);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "UserID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "LastName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Gsm :";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.cbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(444, 344);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(157, 23);
            this.cbStatus.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(293, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 61;
            this.label7.Text = "Status :";
            // 
            // cbConfirmation
            // 
            this.cbConfirmation.BackColor = System.Drawing.Color.MediumPurple;
            this.cbConfirmation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbConfirmation.FormattingEnabled = true;
            this.cbConfirmation.Location = new System.Drawing.Point(444, 411);
            this.cbConfirmation.Name = "cbConfirmation";
            this.cbConfirmation.Size = new System.Drawing.Size(157, 23);
            this.cbConfirmation.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(293, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 30);
            this.label8.TabIndex = 63;
            this.label8.Text = "Confirmation :";
            // 
            // lblGsm
            // 
            this.lblGsm.AutoSize = true;
            this.lblGsm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGsm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGsm.Location = new System.Drawing.Point(132, 248);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(58, 25);
            this.lblGsm.TabIndex = 71;
            this.lblGsm.Text = "None";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(132, 208);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 70;
            this.lblEmail.Text = "None";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(132, 166);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 25);
            this.lblPassword.TabIndex = 69;
            this.lblPassword.Text = "None";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUName.Location = new System.Drawing.Point(132, 125);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(58, 25);
            this.lblUName.TabIndex = 68;
            this.lblUName.Text = "None";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLName.Location = new System.Drawing.Point(132, 83);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 25);
            this.lblLName.TabIndex = 67;
            this.lblLName.Text = "None";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFName.Location = new System.Drawing.Point(132, 44);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(58, 25);
            this.lblFName.TabIndex = 66;
            this.lblFName.Text = "None";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUID.Location = new System.Drawing.Point(132, 9);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(58, 25);
            this.lblUID.TabIndex = 65;
            this.lblUID.Text = "None";
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.lblLName);
            this.pnlDescription.Controls.Add(this.lblGsm);
            this.pnlDescription.Controls.Add(this.lblID);
            this.pnlDescription.Controls.Add(this.lblEmail);
            this.pnlDescription.Controls.Add(this.label1);
            this.pnlDescription.Controls.Add(this.lblPassword);
            this.pnlDescription.Controls.Add(this.label2);
            this.pnlDescription.Controls.Add(this.lblUName);
            this.pnlDescription.Controls.Add(this.label3);
            this.pnlDescription.Controls.Add(this.label4);
            this.pnlDescription.Controls.Add(this.lblFName);
            this.pnlDescription.Controls.Add(this.label5);
            this.pnlDescription.Controls.Add(this.lblUID);
            this.pnlDescription.Controls.Add(this.label6);
            this.pnlDescription.Location = new System.Drawing.Point(0, 328);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(287, 280);
            this.pnlDescription.TabIndex = 72;
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListAll.FlatAppearance.BorderSize = 0;
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListAll.ForeColor = System.Drawing.Color.Cyan;
            this.btnListAll.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListAll.IconColor = System.Drawing.Color.Cyan;
            this.btnListAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListAll.IconSize = 42;
            this.btnListAll.Location = new System.Drawing.Point(652, 344);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(255, 56);
            this.btnListAll.TabIndex = 75;
            this.btnListAll.Text = "List All";
            this.btnListAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnListByStatus
            // 
            this.btnListByStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListByStatus.FlatAppearance.BorderSize = 0;
            this.btnListByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListByStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListByStatus.ForeColor = System.Drawing.Color.DeepPink;
            this.btnListByStatus.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListByStatus.IconColor = System.Drawing.Color.DeepPink;
            this.btnListByStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListByStatus.IconSize = 42;
            this.btnListByStatus.Location = new System.Drawing.Point(652, 468);
            this.btnListByStatus.Name = "btnListByStatus";
            this.btnListByStatus.Size = new System.Drawing.Size(255, 56);
            this.btnListByStatus.TabIndex = 74;
            this.btnListByStatus.Text = "List By Status";
            this.btnListByStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListByStatus.UseVisualStyleBackColor = false;
            this.btnListByStatus.Click += new System.EventHandler(this.btnListByStatus_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 42;
            this.btnBack.Location = new System.Drawing.Point(652, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 56);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "Back ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnListByConfirmation
            // 
            this.btnListByConfirmation.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListByConfirmation.FlatAppearance.BorderSize = 0;
            this.btnListByConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListByConfirmation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListByConfirmation.ForeColor = System.Drawing.Color.Lime;
            this.btnListByConfirmation.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListByConfirmation.IconColor = System.Drawing.Color.Lime;
            this.btnListByConfirmation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListByConfirmation.IconSize = 42;
            this.btnListByConfirmation.Location = new System.Drawing.Point(652, 406);
            this.btnListByConfirmation.Name = "btnListByConfirmation";
            this.btnListByConfirmation.Size = new System.Drawing.Size(255, 56);
            this.btnListByConfirmation.TabIndex = 76;
            this.btnListByConfirmation.Text = "List By Confirmation";
            this.btnListByConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByConfirmation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListByConfirmation.UseVisualStyleBackColor = false;
            this.btnListByConfirmation.Click += new System.EventHandler(this.btnListByConfirmation_Click);
            // 
            // ListWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.btnListByConfirmation);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnListByStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.cbConfirmation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "ListWriter";
            this.Text = "ListWriter";
            this.Load += new System.EventHandler(this.ListWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvWriters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbConfirmation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Panel pnlDescription;
        private FontAwesome.Sharp.IconButton btnListAll;
        private FontAwesome.Sharp.IconButton btnListByStatus;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnListByConfirmation;
    }
}