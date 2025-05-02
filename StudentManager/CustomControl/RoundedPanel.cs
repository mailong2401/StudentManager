using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.CustomControl
{
    public class RoundedPanel : Panel
    {
        public Color BorderColor { get; set; } = Color.Blue; // Màu viền
        public int BorderRadius { get; set; } = 20; // Độ bo tròn viền
        public int BorderThickness { get; set; } = 2; // Độ dày của viền

        public RoundedPanel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.Transparent; // Box trong suốt
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ viền bo tròn
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                // Tạo hình chữ nhật bo tròn
                g.DrawArc(pen, 0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90); // Top-left corner
                g.DrawArc(pen, this.Width - BorderRadius * 2 - 1, 0, BorderRadius * 2, BorderRadius * 2, 270, 90); // Top-right corner
                g.DrawArc(pen, 0, this.Height - BorderRadius * 2 - 1, BorderRadius * 2, BorderRadius * 2, 90, 90); // Bottom-left corner
                g.DrawArc(pen, this.Width - BorderRadius * 2 - 1, this.Height - BorderRadius * 2 - 1, BorderRadius * 2, BorderRadius * 2, 0, 90); // Bottom-right corner

                // Vẽ các cạnh
                g.DrawLine(pen, BorderRadius, 0, this.Width - BorderRadius, 0); // Top edge
                g.DrawLine(pen, this.Width, BorderRadius, this.Width, this.Height - BorderRadius); // Right edge
                g.DrawLine(pen, BorderRadius, this.Height, this.Width - BorderRadius, this.Height); // Bottom edge
                g.DrawLine(pen, 0, BorderRadius, 0, this.Height - BorderRadius); // Left edge
            }
        }
    }

}
