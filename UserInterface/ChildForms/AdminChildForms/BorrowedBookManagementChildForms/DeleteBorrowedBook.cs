using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.ChildForms.AdminChildForms.BorrowedBookManagementChildForms
{
    public partial class DeleteBorrowedBook : Form
    {
        public DeleteBorrowedBook()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Deliver Borrowed Book";
        }
    }
}
