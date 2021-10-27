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
    public partial class UpdateWriterDetails : Form
    {
        int userID = 0;

        public UpdateWriterDetails(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.Text = "Writer Details Update Page";
        }

        private void UpdateWriterDetails_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new UserDal());
            var user = userManager.GetById(userID);

            txtID.Text = user.ID.ToString();
            txtFName.Text = user.FirstName;
            txtLName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;

            if(!string.IsNullOrEmpty(user.Email))
            {
                txtEmail.Text = user.Email;
            }
            if(!string.IsNullOrEmpty(user.Gsm))
            {
                txtGsm.Text = user.Gsm;
            }
        }

        private void btnUpdateWriter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFName.Text) & !string.IsNullOrEmpty(txtLName.Text) & !string.IsNullOrEmpty(txtUsername.Text) & !string.IsNullOrEmpty(txtPassword.Text))
            {

                UserManager userManager = new UserManager(new UserDal());

                var isThere = false;

                foreach(var item in userManager.GetAll())
                {
                    if(txtUsername.Text == item.Username)
                    {
                        isThere = true;
                        break;
                    }
                }

                if(!isThere)
                {
                    User user = new User();

                    user = userManager.GetById(userID);

                    user.FirstName = txtFName.Text;
                    user.LastName = txtLName.Text;
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;

                    if (!string.IsNullOrEmpty(txtEmail.Text))
                    {
                        user.Email = txtEmail.Text;
                    }
                    if (!string.IsNullOrEmpty(txtGsm.Text))
                    {
                        user.Gsm = txtGsm.Text;
                    }

                    userManager.Update(user);

                    MessageBox.Show("Writer Details Updating Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("This Username Already Using!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("First Name,Last Name,Username And Password Can't Be Left Blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
