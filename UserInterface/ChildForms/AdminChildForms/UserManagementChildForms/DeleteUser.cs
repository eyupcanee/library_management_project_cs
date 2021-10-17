using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms.UserManagamentChildForms
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Delete User";
        }

        private void FillDataGridView(string searchString = null)
        {
            UserManager userManager = new UserManager(new UserDal());
            AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
            if(searchString != null)
            {
                var users = (from x in userManager.GetByStatus(true)
                             select new
                             {
                                 x.ID,
                                 x.FirstName,
                                 x.LastName,
                                 x.Username,
                                 x.Password,
                                 x.Email,
                                 x.Gsm,
                                 Authortiy = authorityManager.GetById(x.AuthorityID).AutName,
                                 x.Status
                             }).ToList();
                dgvUsers.DataSource = users.Where(x => x.FirstName.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchString))).ToList();
            }
            else
            {
                var users = (from x in userManager.GetByStatus(true)
                             select new
                             {
                                 x.ID,
                                 x.FirstName,
                                 x.LastName,
                                 x.Username,
                                 x.Password,
                                 x.Email,
                                 x.Gsm,
                                 Authortiy = authorityManager.GetById(x.AuthorityID).AutName,
                                 x.Status
                             }).ToList();
                dgvUsers.DataSource = users;
            }
            
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString() + " " + dgvUsers.CurrentRow.Cells[2].Value.ToString(); 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(txtSearch.Text);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(new UserManagement());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtID.Text))
            {
                User user = new User();
                UserManager userManager = new UserManager(new UserDal());

                user.ID = Convert.ToInt32(txtID.Text);

                userManager.Delete(user);

                MessageBox.Show("User deletion successful","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("You have not selected a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHardDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                User user = new User();
                UserManager userManager = new UserManager(new UserDal());

                user.ID = Convert.ToInt32(txtID.Text);

                DialogResult dialogResult = MessageBox.Show("Deleting the user completely can cause problems with the database! Do you still want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(dialogResult == DialogResult.Yes)
                {
                    userManager.HardDelete(user);
                    MessageBox.Show("User deletion successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Deletion canceled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
