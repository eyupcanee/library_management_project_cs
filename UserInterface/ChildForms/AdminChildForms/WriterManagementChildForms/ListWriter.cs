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

        

        private void ListWriter_Load(object sender, EventArgs e)
        {
            
        }
    }
}
