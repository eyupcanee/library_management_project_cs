
namespace UserInterface.ChildForms.AdminChildForms
{
    partial class WriterManagement
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnListWriter = new FontAwesome.Sharp.IconButton();
            this.btnDeleteWriter = new FontAwesome.Sharp.IconButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnAddWriter = new FontAwesome.Sharp.IconButton();
            this.btnUpdateWriter = new FontAwesome.Sharp.IconButton();
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
            this.splitContainer2.Panel1.Controls.Add(this.btnListWriter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnDeleteWriter);
            this.splitContainer2.Size = new System.Drawing.Size(458, 612);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnListWriter
            // 
            this.btnListWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnListWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListWriter.FlatAppearance.BorderSize = 0;
            this.btnListWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListWriter.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListWriter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnListWriter.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListWriter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btnListWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListWriter.IconSize = 64;
            this.btnListWriter.Location = new System.Drawing.Point(0, 0);
            this.btnListWriter.Name = "btnListWriter";
            this.btnListWriter.Size = new System.Drawing.Size(458, 300);
            this.btnListWriter.TabIndex = 1;
            this.btnListWriter.Text = "List Writers";
            this.btnListWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListWriter.UseVisualStyleBackColor = false;
            this.btnListWriter.Click += new System.EventHandler(this.btnListWriter_Click);
            // 
            // btnDeleteWriter
            // 
            this.btnDeleteWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteWriter.FlatAppearance.BorderSize = 0;
            this.btnDeleteWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWriter.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteWriter.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteWriter.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnDeleteWriter.IconColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteWriter.IconSize = 64;
            this.btnDeleteWriter.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteWriter.Name = "btnDeleteWriter";
            this.btnDeleteWriter.Size = new System.Drawing.Size(458, 308);
            this.btnDeleteWriter.TabIndex = 3;
            this.btnDeleteWriter.Text = "Delete Writer";
            this.btnDeleteWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteWriter.UseVisualStyleBackColor = false;
            this.btnDeleteWriter.Click += new System.EventHandler(this.btnDeleteWriter_Click);
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
            this.splitContainer3.Panel1.Controls.Add(this.btnAddWriter);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnUpdateWriter);
            this.splitContainer3.Size = new System.Drawing.Size(457, 612);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnAddWriter
            // 
            this.btnAddWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWriter.FlatAppearance.BorderSize = 0;
            this.btnAddWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWriter.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddWriter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddWriter.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddWriter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddWriter.IconSize = 64;
            this.btnAddWriter.Location = new System.Drawing.Point(0, 0);
            this.btnAddWriter.Name = "btnAddWriter";
            this.btnAddWriter.Size = new System.Drawing.Size(457, 300);
            this.btnAddWriter.TabIndex = 2;
            this.btnAddWriter.Text = "Add New Writer";
            this.btnAddWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWriter.UseVisualStyleBackColor = false;
            this.btnAddWriter.Click += new System.EventHandler(this.btnAddWriter_Click);
            // 
            // btnUpdateWriter
            // 
            this.btnUpdateWriter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdateWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateWriter.FlatAppearance.BorderSize = 0;
            this.btnUpdateWriter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWriter.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateWriter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnUpdateWriter.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnUpdateWriter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnUpdateWriter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateWriter.IconSize = 42;
            this.btnUpdateWriter.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateWriter.Name = "btnUpdateWriter";
            this.btnUpdateWriter.Size = new System.Drawing.Size(457, 308);
            this.btnUpdateWriter.TabIndex = 4;
            this.btnUpdateWriter.Text = "Update Writer";
            this.btnUpdateWriter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateWriter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWriter.UseVisualStyleBackColor = false;
            this.btnUpdateWriter.Click += new System.EventHandler(this.btnUpdateWriter_Click);
            // 
            // WriterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WriterManagement";
            this.Text = "WriterManager";
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

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private FontAwesome.Sharp.IconButton btnListWriter;
        private FontAwesome.Sharp.IconButton btnDeleteWriter;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private FontAwesome.Sharp.IconButton btnAddWriter;
        private FontAwesome.Sharp.IconButton btnUpdateWriter;
    }
}