using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.CustomControl
{
    public class CustomDateTimePicker : DateTimePicker
    {
        private Image logoImage; // Declare a variable for the logo image

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyyy";
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.BackColor = Color.FromArgb(37, 52, 68); // thêm nếu muốn màu nền nhất quán

            // Load the logo image (make sure the path is correct)
            this.logoImage = Properties.Resources.calendar;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(this.BackColor); // nền tối

            // Draw the text
            using (Brush textBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(this.Text, this.Font, textBrush, new PointF(4, 4));
            }

            // Draw the logo image with zoom effect on the right side of the control
            if (logoImage != null)
            {
                // Set the destination rectangle (right-aligned)
                int logoWidth = 50; // Desired width of the logo (you can adjust this value)
                int logoHeight = 50; // Desired height of the logo (you can adjust this value)
                int logoX = this.ClientRectangle.Width - logoWidth - 4; // 4 is a small margin from the right edge
                int logoY = (this.ClientRectangle.Height - logoHeight) / 2; // Center the logo vertically

                // Create a rectangle for the logo's location
                Rectangle logoRect = new Rectangle(logoX, logoY, logoWidth, logoHeight);

                // Draw the logo image with zoom effect (preserves aspect ratio)
                g.DrawImage(logoImage, logoRect);
            }

            // ❌ Không vẽ border nữa
            // ControlPaint.DrawBorder(g, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
    }


}
