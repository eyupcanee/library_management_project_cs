using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    public partial class AddWriter : Form
    {
        public AddWriter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Add Writer";
        }

        private void AddWriter_Load(object sender, EventArgs e)
        {
            btnHidePassword.Visible = false;

            //CbStatus   
            List<bool> status = new List<bool> { true, false };
            foreach(var item in status)
            {
                cbStatus.Items.Add(item);
            }
            //CbStatusEnd   
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPasswordAgain.PasswordChar = '\0';
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPasswordAgain.PasswordChar = '*';
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
        }

        private void btnAddWriter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) & !string.IsNullOrEmpty(txtPassword.Text) & !string.IsNullOrEmpty(txtPasswordAgain.Text) &
                !string.IsNullOrEmpty(txtFName.Text) & !string.IsNullOrEmpty(txtLName.Text) & cbStatus.SelectedItem != null)
            {
                UserManager userManager = new UserManager(new UserDal());
                var users = userManager.GetAll();
                bool isThere = false;
                foreach (var user in users)
                {
                    if (user.Username == txtUsername.Text)
                    {
                        isThere = true;
                        break;
                    }
                }

                if (!isThere)
                {
                    if (txtPassword.Text == txtPasswordAgain.Text)
                    {
                        User user = new User();
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;
                        user.FirstName = txtFName.Text;
                        user.LastName = txtLName.Text;
                        user.AuthorityID = 3;
                        user.Status = Convert.ToBoolean(cbStatus.SelectedItem);

                        if (!string.IsNullOrEmpty(txtEmail.Text))
                        {
                            user.Email = txtEmail.Text;
                        }
                        if (!string.IsNullOrEmpty(txtGsm.Text))
                        {
                            user.Gsm = txtGsm.Text;
                        }
           
                        WriterManager writerManager = new WriterManager(new WriterDal());
                        Writer writer = new Writer();

                        userManager.Add(user);
                        writer.Confirmation = false;
                        writer.Status = true;
                        writer.UserID = userManager.GetLastUser().ID;
                        writerManager.Add(writer);

                        MessageBox.Show("Writer Adding Succesful!For Confirmation Go Confirmation Page!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtUsername.Text = string.Empty;
                        txtFName.Text = string.Empty;
                        txtLName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtPasswordAgain.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        txtGsm.Text = string.Empty;
                        cbStatus.SelectedItem = null;
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = string.Empty;
                        txtPasswordAgain.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("This Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Username,Password,Password Again,First Name,Last Name And Status Can't Be Left Blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new WriterManagement());
        }
    }
}
