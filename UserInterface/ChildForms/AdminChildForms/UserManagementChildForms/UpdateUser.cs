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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Update User";
        }

        private void FillDataGridView(string searchString = null)
        {
            UserManager userManager = new UserManager(new UserDal());
            AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
            if (searchString != null)
            {
                var users = (from x in userManager.GetAll()
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
                var users = (from x in userManager.GetAll()
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

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            //cbAuthority
            AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
            var auts = (from x in authorityManager.GetAll()
                        select new
                        {
                            x.ID,
                            x.AutName
                        }).ToList();
            cbAuthority.DataSource = auts;
            cbAuthority.DisplayMember = "AutName";
            cbAuthority.ValueMember = "ID";
            cbAuthority.SelectedItem = null;
            //cbAuthority End

            //cbStatus
            List<bool> status = new List<bool> { true, false };
            foreach (var item in status)
            {
                cbStatus.Items.Add(item);
            }
            cbStatus.SelectedItem = null;
            //cbStatus End
        }

        int FirstAutId = 0;
        int LastAutId = 0;

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            if(!string.IsNullOrEmpty(txtID.Text))
            {
                UserManager userManager = new UserManager(new UserDal());
                var user = userManager.GetById(Convert.ToInt32(txtID.Text));
                txtFName.Text = user.FirstName;
                txtLName.Text = user.LastName;
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtEmail.Text = user.Email;
                txtGsm.Text = user.Gsm;
                cbAuthority.SelectedValue = user.AuthorityID;
                cbStatus.SelectedItem = user.Status;
                FirstAutId = user.AuthorityID;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(txtSearch.Text);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) & !string.IsNullOrEmpty(txtPassword.Text) &!string.IsNullOrEmpty(txtFName.Text) & 
                !string.IsNullOrEmpty(txtLName.Text) & cbAuthority.SelectedValue != null & cbStatus.SelectedItem != null)
            {
                User user = new User();
                UserManager userManager = new UserManager(new UserDal());

                user.ID = Convert.ToInt32(txtID.Text);
                user.FirstName = txtFName.Text;
                user.LastName = txtLName.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.Gsm = txtGsm.Text;
                user.Email = txtEmail.Text;
                user.AuthorityID = Convert.ToInt32(cbAuthority.SelectedValue);
                user.Status = Convert.ToBoolean(cbStatus.SelectedItem);

                LastAutId = Convert.ToInt32(cbAuthority.SelectedValue); 

                userManager.Update(user);

                if(FirstAutId != 0 & FirstAutId != 3 & LastAutId == 3)
                {
                    WriterManager writerManager = new WriterManager(new WriterDal());
                    Writer writer = new Writer();
                    writer.UserID = Convert.ToInt32(txtID.Text);
                    writer.Confirmation = false;
                    writer.Status = Convert.ToBoolean(cbStatus.SelectedItem);
                    writerManager.Add(writer);
                    MessageBox.Show("You have given writer authority to the user. Please confirm on the Confirmation page.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if(FirstAutId == 3 & LastAutId != 3 & LastAutId != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You have changed the user's writer authority. Delete the user's writer record completely?Note:Deleting it may cause problems in the database. Deactivate it by pressing No!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if(dialogResult == DialogResult.Yes)
                    {
                        WriterManager writerManager = new WriterManager(new WriterDal());
                        Writer writer = new Writer();
                        writer.UserID = Convert.ToInt32(txtID.Text);
                        writerManager.HardDelete(writer);
                    }
                    else if(dialogResult == DialogResult.No)
                    {
                        WriterManager writerManager = new WriterManager(new WriterDal());
                        Writer writer = new Writer();
                        writer.UserID = Convert.ToInt32(txtID.Text);
                        writerManager.Delete(writer);
                    }
                }

                MessageBox.Show("User update successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("First Name,Last Name,Username,Password,Authority and Status Can't be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(new UserManagement());
        }
    }
}
