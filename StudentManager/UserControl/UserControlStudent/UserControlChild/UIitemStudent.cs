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
    public partial class UIitemStudent : UserControl
    {
        public UIitemStudent()
        {
            InitializeComponent();
        }
        public void setItem(String id, String name, String date, String render, String dress, String phone, String dclass)
        {
            lbid.Text = id;
            lbname.Text = name;
            lbdate.Text = date;
            lbrender.Text = render;
            lbdress.Text = dress;
            lbphone.Text = phone;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
