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

namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    public partial class DeleteWriter : Form
    {
        public DeleteWriter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Delete Writer";
        }

        private void FillDataGridView(string searchText = null)
        {
            if(!string.IsNullOrEmpty(searchText))
            {
                UserManager userManager = new UserManager(new UserDal());
                AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
                var users = (from x in userManager.GetByAuthority(3)
                             select new
                             {
                                 x.ID,
                                 x.FirstName,
                                 x.LastName,
                                 x.Username,
                                 x.Password,
                                 x.Email,
                                 x.Gsm,
                                 Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                 x.Status
                             }).ToList();
                searchText.ToLower();
                dgvWriters.DataSource = users.Where(x => x.FirstName.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
            }
            else
            {
                UserManager userManager = new UserManager(new UserDal());
                AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
                var users = (from x in userManager.GetByAuthority(3)
                             select new
                             {
                                 x.ID,
                                 x.FirstName,
                                 x.LastName,
                                 x.Username,
                                 x.Password,
                                 x.Email,
                                 x.Gsm,
                                 Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                 x.Status
                             }).ToList();
                dgvWriters.DataSource = users;
            }
        }

        private void DeleteWriter_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(txtSearch.Text);
        }

        private void dgvWriters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWriterID.Text = dgvWriters.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dgvWriters.CurrentRow.Cells[1].Value.ToString() + " " + dgvWriters.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtWriterID.Text))
            {
                WriterManager writerManager = new WriterManager(new WriterDal());
                UserManager userManager = new UserManager(new UserDal());

                Writer writer = new Writer();
                writer = writerManager.GetById(Convert.ToInt32(txtWriterID.Text));
                writerManager.Delete(writer);
                User user = new User();
                user.ID = writer.UserID;
                userManager.Delete(user);
                MessageBox.Show("Writer Deletion Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("You Must Select A Writer In Grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHardDelete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtWriterID.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Deleting the writer completely can cause problems with the database! Do you still want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(dialogResult == DialogResult.Yes)
                {

                    WriterManager writerManager = new WriterManager(new WriterDal());
                    UserManager userManager = new UserManager(new UserDal());

                    Writer writer = new Writer();
                    writer = writerManager.GetById(Convert.ToInt32(txtWriterID.Text));
                    User user = new User();
                    user.ID = writer.UserID;
                    writerManager.HardDelete(writer);
                    userManager.HardDelete(user);

                    MessageBox.Show("Writer Deletion Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Deletion canceled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You Must Select A Writer In Grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new WriterManagement());
        }
    }
}
