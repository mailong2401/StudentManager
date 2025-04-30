using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudentManager.CustomControl
{
    public class BorderlessComboBox : ComboBox
    {
        private int borderRadius = 10;

        // ➕ Thêm thuộc tính Placeholder
        public string Placeholder { get; set; } = "Chọn một mục...";
        private Color PlaceholderColor = Color.Gray;

        public BorderlessComboBox()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(37, 52, 68);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.Resize += (s, e) => UpdateRegion();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, borderRadius))
            {
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int arcSize = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
            path.AddArc(rect.Right - arcSize, rect.Y, arcSize, arcSize, 270, 90);
            path.AddArc(rect.Right - arcSize, rect.Bottom - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - arcSize, arcSize, arcSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                // Nếu đang được chọn hoặc hover
                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                Color textColor = Color.White;
                Color bgColor = isSelected ? Color.FromArgb(60, 80, 100) : this.BackColor;

                using (SolidBrush backgroundBrush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                }

                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(
                        this.GetItemText(Items[e.Index]),
                        this.Font,
                        textBrush,
                        e.Bounds
                    );
                }
            }

            e.DrawFocusRectangle();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 🎯 Vẽ mũi tên trắng
            Rectangle arrowRect = new Rectangle(this.Width - 30, (this.Height - 10) / 2, 10, 10);
            using (Pen arrowPen = new Pen(Color.White, 2))
            {
                Point p1 = new Point(arrowRect.Left, arrowRect.Top);
                Point p2 = new Point(arrowRect.Left + arrowRect.Width / 2, arrowRect.Bottom);
                Point p3 = new Point(arrowRect.Right, arrowRect.Top);
                g.DrawLines(arrowPen, new Point[] { p1, p2, p3 });
            }

            // ✨ Hiển thị placeholder nếu chưa chọn gì
            if (this.SelectedIndex == -1 && !string.IsNullOrEmpty(Placeholder))
            {
                using (Brush placeholderBrush = new SolidBrush(PlaceholderColor))
                {
                    Rectangle textRect = new Rectangle(5, 3, this.Width - 40, this.Height - 6);
                    g.DrawString(Placeholder, this.Font, placeholderBrush, textRect);
                }
            }
            else if (this.SelectedIndex >= 0)
            {
                // Vẽ nội dung bình thường
                using (Brush textBrush = new SolidBrush(this.ForeColor))
                {
                    Rectangle textRect = new Rectangle(5, 3, this.Width - 40, this.Height - 6);
                    g.DrawString(this.GetItemText(this.SelectedItem), this.Font, textBrush, textRect);
                }
            }
        }
    }
}
