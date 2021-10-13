
namespace UserInterface.Interfaces
{
    partial class AUserInterface
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
            this.panelShadow = new System.Windows.Forms.Panel();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.CurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackLogin = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChildFormIcon)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(913, 8);
            this.panelShadow.TabIndex = 6;
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChildForm.Location = new System.Drawing.Point(66, 12);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(62, 25);
            this.lblChildForm.TabIndex = 1;
            this.lblChildForm.Text = "Home";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblChildForm);
            this.panelTitleBar.Controls.Add(this.CurrentChildFormIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(913, 60);
            this.panelTitleBar.TabIndex = 5;
            // 
            // CurrentChildFormIcon
            // 
            this.CurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.CurrentChildFormIcon.ForeColor = System.Drawing.Color.MediumPurple;
            this.CurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentChildFormIcon.IconColor = System.Drawing.Color.MediumPurple;
            this.CurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CurrentChildFormIcon.IconSize = 47;
            this.CurrentChildFormIcon.Location = new System.Drawing.Point(8, 8);
            this.CurrentChildFormIcon.Name = "CurrentChildFormIcon";
            this.CurrentChildFormIcon.Size = new System.Drawing.Size(52, 47);
            this.CurrentChildFormIcon.TabIndex = 0;
            this.CurrentChildFormIcon.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 134);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblEmail);
            this.panelLogo.Controls.Add(this.lblGsm);
            this.panelLogo.Controls.Add(this.label4);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.lblAuthority);
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.lblUsername);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 134);
            this.panelLogo.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(74, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblGsm
            // 
            this.lblGsm.AutoSize = true;
            this.lblGsm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGsm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGsm.Location = new System.Drawing.Point(62, 97);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(42, 20);
            this.lblGsm.TabIndex = 7;
            this.lblGsm.Text = "Gsm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gsm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email :";
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthority.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthority.Location = new System.Drawing.Point(101, 40);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(78, 20);
            this.lblAuthority.TabIndex = 3;
            this.lblAuthority.Text = "Authority ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(22, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authority :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(137, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Logged As : ";
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackLogin.FlatAppearance.BorderSize = 0;
            this.btnBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBackLogin.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBackLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBackLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackLogin.IconSize = 40;
            this.btnBackLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackLogin.Location = new System.Drawing.Point(0, 594);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBackLogin.Size = new System.Drawing.Size(220, 43);
            this.btnBackLogin.TabIndex = 6;
            this.btnBackLogin.Text = "Back To Login Screen";
            this.btnBackLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.GalacticRepublic;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 40;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 184);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 50);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnBackLogin);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1133, 681);
            this.panelDesktop.TabIndex = 7;
            // 
            // AUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 681);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Name = "AUserInterface";
            this.Text = "UserInterface";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChildFormIcon)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox CurrentChildFormIcon;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBackLogin;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel panelDesktop;
    }
}