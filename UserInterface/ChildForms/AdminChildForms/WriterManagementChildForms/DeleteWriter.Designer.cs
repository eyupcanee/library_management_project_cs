
namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    partial class DeleteWriter
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
            this.txtWriterID = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnHardDelete = new FontAwesome.Sharp.IconButton();
            this.btnListAll = new FontAwesome.Sharp.IconButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWriters
            // 
            this.dgvWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriters.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvWriters.Location = new System.Drawing.Point(0, 0);
            this.dgvWriters.Name = "dgvWriters";
            this.dgvWriters.RowTemplate.Height = 25;
            this.dgvWriters.Size = new System.Drawing.Size(919, 343);
            this.dgvWriters.TabIndex = 0;
            this.dgvWriters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWriters_CellClick);
            // 
            // txtWriterID
            // 
            this.txtWriterID.BackColor = System.Drawing.Color.MediumPurple;
            this.txtWriterID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWriterID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWriterID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtWriterID.Location = new System.Drawing.Point(134, 418);
            this.txtWriterID.Name = "txtWriterID";
            this.txtWriterID.ReadOnly = true;
            this.txtWriterID.Size = new System.Drawing.Size(155, 20);
            this.txtWriterID.TabIndex = 109;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(13, 410);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 30);
            this.lblUsername.TabIndex = 110;
            this.lblUsername.Text = "ID :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(134, 370);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 112;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblID.Location = new System.Drawing.Point(13, 362);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 30);
            this.lblID.TabIndex = 111;
            this.lblID.Text = "Search :";
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
            this.btnBack.Location = new System.Drawing.Point(625, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 46);
            this.btnBack.TabIndex = 116;
            this.btnBack.Text = "Back ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnDelete.IconColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 42;
            this.btnDelete.Location = new System.Drawing.Point(625, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(255, 46);
            this.btnDelete.TabIndex = 115;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHardDelete
            // 
            this.btnHardDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.btnHardDelete.FlatAppearance.BorderSize = 0;
            this.btnHardDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHardDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnHardDelete.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnHardDelete.IconColor = System.Drawing.Color.Yellow;
            this.btnHardDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHardDelete.IconSize = 42;
            this.btnHardDelete.Location = new System.Drawing.Point(625, 474);
            this.btnHardDelete.Name = "btnHardDelete";
            this.btnHardDelete.Size = new System.Drawing.Size(255, 46);
            this.btnHardDelete.TabIndex = 114;
            this.btnHardDelete.Text = "Hard Delete";
            this.btnHardDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHardDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHardDelete.UseVisualStyleBackColor = false;
            this.btnHardDelete.Click += new System.EventHandler(this.btnHardDelete_Click);
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
            this.btnListAll.Location = new System.Drawing.Point(625, 370);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(255, 46);
            this.btnListAll.TabIndex = 113;
            this.btnListAll.Text = "List All";
            this.btnListAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.MediumPurple;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFullName.Location = new System.Drawing.Point(134, 462);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(157, 20);
            this.txtFullName.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 117;
            this.label1.Text = "Full Name :";
            // 
            // DeleteWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHardDelete);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtWriterID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dgvWriters);
            this.Name = "DeleteWriter";
            this.Text = "DeleteWriter";
            this.Load += new System.EventHandler(this.DeleteWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWriters;
        private System.Windows.Forms.TextBox txtWriterID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnHardDelete;
        private FontAwesome.Sharp.IconButton btnListAll;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
    }
}