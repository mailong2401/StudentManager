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
    public partial class UIItemBranch : UserControl
    {
        public UIItemBranch()
        {
            InitializeComponent();
        }
        public void setItem(string id, string name, string khoa)
        {
            lbidnganh.Text = id;
            lbnamenganh.Text = name;
            lbnamekhoa.Text = khoa;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fEditItemBranch mainForm = new fEditItemBranch(lbid.Text, lbnamenganh.Text,lbkhoa.Text);
            if (mainForm.ShowDialog() == DialogResult.OK) // Giả sử OK có nghĩa là chỉnh sửa thành công
            {
                MessageBox.Show("Sửa thành công!");
            }
        }
    }
}
