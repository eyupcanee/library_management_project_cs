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

namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    public partial class ListWriter : Form
    {
        public ListWriter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "List Writer";
        }

        private void FillDataGridView(int process = 0)
        {
            if(process == 1)
            {
                if(cbStatus.SelectedItem != null)
                {
                    WriterManager writerManager = new WriterManager(new WriterDal());
                    var writers = (from x in writerManager.GetByStatus(true)
                                   select new
                                   {
                                       x.ID,
                                       x.UserID,
                                       x.Confirmation,
                                       x.Status
                                   }).ToList();
                    dgvWriters.DataSource = writers;
                }
                else
                {
                    MessageBox.Show("Status Can Not Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(process == 2)
            {
                if (cbStatus.SelectedItem != null)
                {
                    WriterManager writerManager = new WriterManager(new WriterDal());
                    var writers = (from x in writerManager.GetByStatus(false)
                                   select new
                                   {
                                       x.ID,
                                       x.UserID,
                                       x.Confirmation,
                                       x.Status
                                   }).ToList();
                    dgvWriters.DataSource = writers;
                }
                else
                {
                    MessageBox.Show("Status Can Not Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(process == 3)
            {
                if (cbConfirmation.SelectedItem != null)
                {
                    WriterManager writerManager = new WriterManager(new WriterDal());
                    var writers = (from x in writerManager.GetByConfirmation(true)
                                   select new
                                   {
                                       x.ID,
                                       x.UserID,
                                       x.Confirmation,
                                       x.Status
                                   }).ToList();
                    dgvWriters.DataSource = writers;
                }
                else
                {
                    MessageBox.Show("Confirmation Can Not Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(process == 4)
            {
                if (cbConfirmation.SelectedItem != null)
                {
                    WriterManager writerManager = new WriterManager(new WriterDal());
                    var writers = (from x in writerManager.GetByConfirmation(false)
                                   select new
                                   {
                                       x.ID,
                                       x.UserID,
                                       x.Confirmation,
                                       x.Status
                                   }).ToList();
                    dgvWriters.DataSource = writers;
                }
                else
                {
                    MessageBox.Show("Confirmation Can Not Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                WriterManager writerManager = new WriterManager(new WriterDal());
                var writers = (from x in writerManager.GetAll()
                               select new
                               {
                                   x.ID,
                                   x.UserID,
                                   x.Confirmation,
                                   x.Status
                               }).ToList();
                dgvWriters.DataSource = writers;
                //MessageBox.Show("We encountered an error while performing your transaction!Contact The Developer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListWriter_Load(object sender, EventArgs e)
        {
            pnlDescription.Visible = false;

            List<bool> boolValues = new List<bool> { true, false };
            //ComboBoxes

            foreach(var b in boolValues)
            {
                cbStatus.Items.Add(b);
                cbConfirmation.Items.Add(b);
            }

            //ComboBoxesEnd

            FillDataGridView();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnListByConfirmation_Click(object sender, EventArgs e)
        {
            if(Convert.ToBoolean(cbConfirmation.SelectedItem) == true)
            {
                FillDataGridView(3);
            }
            else if(Convert.ToBoolean(cbConfirmation.SelectedItem) == false)
            {
                FillDataGridView(4);
            }

        }

        private void btnListByStatus_Click(object sender, EventArgs e)
        {
            if(Convert.ToBoolean(cbStatus.SelectedItem) == true)
            {
                FillDataGridView(1);
            }
            else if(Convert.ToBoolean(cbStatus.SelectedItem) == false)
            {
                FillDataGridView(2);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new WriterManagement());
        }

        private void dgvWriters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDescription.Visible = true;
            int id = Convert.ToInt32(dgvWriters.CurrentRow.Cells[0].Value);
            WriterManager writerManager = new WriterManager(new WriterDal());
            int writerId = writerManager.GetById(id).UserID;
            UserManager userManager = new UserManager(new UserDal());
            var wDetail = userManager.GetById(writerId);
            lblUID.Text = wDetail.ID.ToString();
            lblFName.Text = wDetail.FirstName;
            lblLName.Text = wDetail.LastName;
            lblUName.Text = wDetail.Username;
            lblPassword.Text = wDetail.Password;
            if(wDetail.Email != null)
            {
                lblEmail.Text = wDetail.Email;
            }
            if(wDetail.Gsm != null)
            {
                lblGsm.Text = wDetail.Gsm;
            }
        }

    }
}
