
namespace UserInterface.ChildForms.AdminChildForms.BookManagementChildForms
{
    partial class ListBook
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnListByPublisher = new FontAwesome.Sharp.IconButton();
            this.btnListByStatus = new FontAwesome.Sharp.IconButton();
            this.btnListAll = new FontAwesome.Sharp.IconButton();
            this.btnListByWriter = new FontAwesome.Sharp.IconButton();
            this.cbPublishers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWriters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 25;
            this.dgvBooks.Size = new System.Drawing.Size(919, 318);
            this.dgvBooks.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.cbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(121, 549);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(157, 23);
            this.cbStatus.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 30);
            this.label5.TabIndex = 59;
            this.label5.Text = "Status :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(121, 342);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblID.Location = new System.Drawing.Point(13, 334);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 30);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "Search :";
            // 
            // btnListByPublisher
            // 
            this.btnListByPublisher.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListByPublisher.FlatAppearance.BorderSize = 0;
            this.btnListByPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListByPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListByPublisher.ForeColor = System.Drawing.Color.Yellow;
            this.btnListByPublisher.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListByPublisher.IconColor = System.Drawing.Color.Yellow;
            this.btnListByPublisher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListByPublisher.IconSize = 42;
            this.btnListByPublisher.Location = new System.Drawing.Point(316, 475);
            this.btnListByPublisher.Name = "btnListByPublisher";
            this.btnListByPublisher.Size = new System.Drawing.Size(255, 44);
            this.btnListByPublisher.TabIndex = 63;
            this.btnListByPublisher.Text = "List By Publisher";
            this.btnListByPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByPublisher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListByPublisher.UseVisualStyleBackColor = false;
            this.btnListByPublisher.Click += new System.EventHandler(this.btnListByPublisher_Click);
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
            this.btnListByStatus.Location = new System.Drawing.Point(316, 534);
            this.btnListByStatus.Name = "btnListByStatus";
            this.btnListByStatus.Size = new System.Drawing.Size(255, 44);
            this.btnListByStatus.TabIndex = 62;
            this.btnListByStatus.Text = "List By Status";
            this.btnListByStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListByStatus.UseVisualStyleBackColor = false;
            this.btnListByStatus.Click += new System.EventHandler(this.btnListByStatus_Click);
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
            this.btnListAll.Location = new System.Drawing.Point(652, 410);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(255, 44);
            this.btnListAll.TabIndex = 65;
            this.btnListAll.Text = "List All";
            this.btnListAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnListByWriter
            // 
            this.btnListByWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListByWriter.FlatAppearance.BorderSize = 0;
            this.btnListByWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListByWriter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListByWriter.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnListByWriter.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListByWriter.IconColor = System.Drawing.Color.DarkViolet;
            this.btnListByWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListByWriter.IconSize = 42;
            this.btnListByWriter.Location = new System.Drawing.Point(316, 410);
            this.btnListByWriter.Name = "btnListByWriter";
            this.btnListByWriter.Size = new System.Drawing.Size(255, 44);
            this.btnListByWriter.TabIndex = 64;
            this.btnListByWriter.Text = "List By Writer";
            this.btnListByWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListByWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListByWriter.UseVisualStyleBackColor = false;
            this.btnListByWriter.Click += new System.EventHandler(this.btnListByWriter_Click);
            // 
            // cbPublishers
            // 
            this.cbPublishers.BackColor = System.Drawing.Color.MediumPurple;
            this.cbPublishers.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbPublishers.FormattingEnabled = true;
            this.cbPublishers.Location = new System.Drawing.Point(121, 490);
            this.cbPublishers.Name = "cbPublishers";
            this.cbPublishers.Size = new System.Drawing.Size(157, 23);
            this.cbPublishers.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Publisher :";
            // 
            // cbWriters
            // 
            this.cbWriters.BackColor = System.Drawing.Color.MediumPurple;
            this.cbWriters.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbWriters.FormattingEnabled = true;
            this.cbWriters.Location = new System.Drawing.Point(121, 419);
            this.cbWriters.Name = "cbWriters";
            this.cbWriters.Size = new System.Drawing.Size(157, 23);
            this.cbWriters.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Writer :";
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
            this.btnBack.Location = new System.Drawing.Point(652, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 44);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbWriters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPublishers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnListByWriter);
            this.Controls.Add(this.btnListByPublisher);
            this.Controls.Add(this.btnListByStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvBooks);
            this.Name = "ListBook";
            this.Text = "ListBook";
            this.Load += new System.EventHandler(this.ListBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.IconButton btnListByPublisher;
        private FontAwesome.Sharp.IconButton btnListByStatus;
        private FontAwesome.Sharp.IconButton btnListAll;
        private FontAwesome.Sharp.IconButton btnListByWriter;
        private System.Windows.Forms.ComboBox cbPublishers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWriters;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}