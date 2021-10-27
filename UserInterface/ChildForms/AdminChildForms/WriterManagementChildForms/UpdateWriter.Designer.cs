
namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    partial class UpdateWriter
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
            this.btnUpdateWriter = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnUpdateWriterDetails = new FontAwesome.Sharp.IconButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbConfirmations = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWriterID = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.dgvWriters.Size = new System.Drawing.Size(919, 307);
            this.dgvWriters.TabIndex = 0;
            this.dgvWriters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWriters_CellClick);
            // 
            // btnUpdateWriter
            // 
            this.btnUpdateWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdateWriter.FlatAppearance.BorderSize = 0;
            this.btnUpdateWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWriter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateWriter.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUpdateWriter.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnUpdateWriter.IconColor = System.Drawing.Color.DeepPink;
            this.btnUpdateWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateWriter.IconSize = 42;
            this.btnUpdateWriter.Location = new System.Drawing.Point(652, 376);
            this.btnUpdateWriter.Name = "btnUpdateWriter";
            this.btnUpdateWriter.Size = new System.Drawing.Size(255, 57);
            this.btnUpdateWriter.TabIndex = 99;
            this.btnUpdateWriter.Text = "Update Writer";
            this.btnUpdateWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWriter.UseVisualStyleBackColor = false;
            this.btnUpdateWriter.Click += new System.EventHandler(this.btnUpdateWriter_Click);
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
            this.btnBack.Location = new System.Drawing.Point(652, 502);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 57);
            this.btnBack.TabIndex = 98;
            this.btnBack.Text = "Back ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateWriterDetails
            // 
            this.btnUpdateWriterDetails.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdateWriterDetails.FlatAppearance.BorderSize = 0;
            this.btnUpdateWriterDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWriterDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateWriterDetails.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnUpdateWriterDetails.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnUpdateWriterDetails.IconColor = System.Drawing.Color.DarkViolet;
            this.btnUpdateWriterDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateWriterDetails.IconSize = 42;
            this.btnUpdateWriterDetails.Location = new System.Drawing.Point(652, 439);
            this.btnUpdateWriterDetails.Name = "btnUpdateWriterDetails";
            this.btnUpdateWriterDetails.Size = new System.Drawing.Size(255, 57);
            this.btnUpdateWriterDetails.TabIndex = 100;
            this.btnUpdateWriterDetails.Text = "Update Writer Details";
            this.btnUpdateWriterDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateWriterDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWriterDetails.UseVisualStyleBackColor = false;
            this.btnUpdateWriterDetails.Click += new System.EventHandler(this.btnUpdateWriterDetails_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.cbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(163, 544);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(172, 23);
            this.cbStatus.TabIndex = 104;
            // 
            // cbConfirmations
            // 
            this.cbConfirmations.BackColor = System.Drawing.Color.MediumPurple;
            this.cbConfirmations.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbConfirmations.FormattingEnabled = true;
            this.cbConfirmations.Location = new System.Drawing.Point(163, 494);
            this.cbConfirmations.Name = "cbConfirmations";
            this.cbConfirmations.Size = new System.Drawing.Size(172, 23);
            this.cbConfirmations.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 30);
            this.label6.TabIndex = 102;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 101;
            this.label5.Text = "Confirmation :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(12, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 32);
            this.label8.TabIndex = 105;
            this.label8.Text = "If You Want To Update More Features";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 106;
            this.label1.Text = "Clik Update Writer Details --->";
            // 
            // txtWriterID
            // 
            this.txtWriterID.BackColor = System.Drawing.Color.MediumPurple;
            this.txtWriterID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWriterID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWriterID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtWriterID.Location = new System.Drawing.Point(77, 338);
            this.txtWriterID.Name = "txtWriterID";
            this.txtWriterID.ReadOnly = true;
            this.txtWriterID.Size = new System.Drawing.Size(155, 20);
            this.txtWriterID.TabIndex = 107;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(12, 330);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 30);
            this.lblUsername.TabIndex = 108;
            this.lblUsername.Text = "ID :";
            // 
            // UpdateWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.txtWriterID);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbConfirmations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateWriterDetails);
            this.Controls.Add(this.btnUpdateWriter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvWriters);
            this.Name = "UpdateWriter";
            this.Text = "UpdateWriter";
            this.Load += new System.EventHandler(this.UpdateWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWriters;
        private FontAwesome.Sharp.IconButton btnUpdateWriter;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnUpdateWriterDetails;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbConfirmations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWriterID;
        private System.Windows.Forms.Label lblUsername;
    }
}