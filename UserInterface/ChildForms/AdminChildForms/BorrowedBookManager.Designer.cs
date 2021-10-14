
namespace UserInterface.ChildForms.AdminChildForms
{
    partial class BorrowedBookManager
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
            this.btnListBBook = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDeliverBBook = new FontAwesome.Sharp.IconButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.btnUpdateBBook = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListBBook
            // 
            this.btnListBBook.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListBBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListBBook.FlatAppearance.BorderSize = 0;
            this.btnListBBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListBBook.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListBBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnListBBook.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListBBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnListBBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListBBook.IconSize = 64;
            this.btnListBBook.Location = new System.Drawing.Point(0, 0);
            this.btnListBBook.Name = "btnListBBook";
            this.btnListBBook.Size = new System.Drawing.Size(458, 300);
            this.btnListBBook.TabIndex = 1;
            this.btnListBBook.Text = "List Borrowed Book";
            this.btnListBBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListBBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListBBook.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(919, 612);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnListBBook);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDeliverBBook);
            this.splitContainer2.Size = new System.Drawing.Size(458, 612);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnDeliverBBook
            // 
            this.btnDeliverBBook.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDeliverBBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeliverBBook.FlatAppearance.BorderSize = 0;
            this.btnDeliverBBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliverBBook.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeliverBBook.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnDeliverBBook.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnDeliverBBook.IconColor = System.Drawing.Color.SpringGreen;
            this.btnDeliverBBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeliverBBook.IconSize = 64;
            this.btnDeliverBBook.Location = new System.Drawing.Point(0, 0);
            this.btnDeliverBBook.Name = "btnDeliverBBook";
            this.btnDeliverBBook.Size = new System.Drawing.Size(458, 308);
            this.btnDeliverBBook.TabIndex = 3;
            this.btnDeliverBBook.Text = "Deliver Borrow";
            this.btnDeliverBBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeliverBBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeliverBBook.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnAddUser);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnUpdateBBook);
            this.splitContainer3.Size = new System.Drawing.Size(457, 612);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUser.IconSize = 64;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(457, 300);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "AddBBook";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBBook
            // 
            this.btnUpdateBBook.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdateBBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateBBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBBook.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnUpdateBBook.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnUpdateBBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnUpdateBBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateBBook.IconSize = 42;
            this.btnUpdateBBook.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateBBook.Name = "btnUpdateBBook";
            this.btnUpdateBBook.Size = new System.Drawing.Size(457, 308);
            this.btnUpdateBBook.TabIndex = 4;
            this.btnUpdateBBook.Text = "Update Borrow";
            this.btnUpdateBBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateBBook.UseVisualStyleBackColor = false;
            // 
            // BorrowedBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BorrowedBookManager";
            this.Text = "BorrowedBookManager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListBBook;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private FontAwesome.Sharp.IconButton btnDeliverBBook;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnUpdateBBook;
    }
}