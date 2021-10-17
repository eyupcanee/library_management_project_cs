using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "List User";
        }

        private void FillDataGridView(int process = 3,string searchText = null)
        {
            UserManager userManager = new UserManager(new UserDal());
            AuthorityManager authorityManager = new AuthorityManager(new AuthorityDal());
            if(searchText == null)
            {
                if (process == 0)
                {
                    var users = (from x in userManager.GetByStatus(false)
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
                    dgvUsers.DataSource = users;
                }
                else if (process == 1)
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
                                     Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                     x.Status
                                 }).ToList();
                    dgvUsers.DataSource = users;
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
                                     Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                     x.Status
                                 }).ToList();
                    dgvUsers.DataSource = users;
                }
            }
            else
            {
                if(process == 0)
                {
                    var users = (from x in userManager.GetByStatus(false)
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
                    dgvUsers.DataSource = users.Where(x => x.FirstName.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText.ToLower()))).ToList();
                }
                else if(process == 1)
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
                                     Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                     x.Status
                                 }).ToList();
                    dgvUsers.DataSource = users.Where(x => x.FirstName.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText.ToLower()))).ToList();
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
                                     Authority = authorityManager.GetById(x.AuthorityID).AutName,
                                     x.Status
                                 }).ToList();
                    dgvUsers.DataSource = users.Where(x => x.FirstName.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText.ToLower()))).ToList();
                } 
            }
            
            
        }

        private void ListUser_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            //cbStatus
            List<bool> status = new List<bool> { true, false };
            foreach (var item in status)
            {
                cbStatus.Items.Add(item);
            }
            //cbStatus End
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbStatus.SelectedItem == null)
            {
                FillDataGridView(3,txtSearch.Text);
            }
            else
            {
                FillDataGridView(Convert.ToInt32(cbStatus.SelectedItem), txtSearch.Text);
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            FillDataGridView(3);
        }

        private void btnListByStatus_Click(object sender, EventArgs e)
        {
            FillDataGridView(Convert.ToInt32(cbStatus.SelectedItem));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new UserManagement());
        }
    }
}
