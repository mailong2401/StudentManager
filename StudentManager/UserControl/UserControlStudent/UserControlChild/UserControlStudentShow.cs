using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlStudentShow : UserControl
    {
        public UserControlStudentShow()
        {
            InitializeComponent();
            AddTable();
        }

        private void AddTable()
        {
            tableLayoutPanel1.Controls.Add(exampleBox, 0, 0);
            exampleBox.Dock = DockStyle.Fill;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
