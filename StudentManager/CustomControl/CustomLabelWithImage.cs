using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManager.CustomControl
{
    public class CustomLabelWithImage : Label
    {
        private Image _icon;
        private int _iconSize = 24;
        private int _padding = 5;

        [Category("Custom")]
        public Image Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        public int IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        public int IconPadding
        {
            get => _padding;
            set
            {
                _padding = value;
                Invalidate();
            }
        }

        public CustomLabelWithImage()
        {
            this.AutoSize = false;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            // Đảm bảo rằng chiều rộng của label đủ lớn để chứa cả text và icon
            if (_icon != null)
            {
                // Đảm bảo rằng chiều rộng của label đủ lớn để chứa cả text và icon
                int requiredWidth = _iconSize + _padding * 2 + TextRenderer.MeasureText(this.Text, this.Font).Width;
                this.Width = Math.Max(this.Width, requiredWidth);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;

            // Vị trí của icon ở bên phải
            int iconX = this.Width - _iconSize - _padding;
            int iconY = (this.Height - _iconSize) / 2;

            // Vẽ icon nếu có
            if (_icon != null)
            {
                Rectangle iconRect = new Rectangle(iconX, iconY, _iconSize, _iconSize);
                g.DrawImage(_icon, iconRect);
            }

            // Vẽ text bên trái
            int textWidth = this.Width - (_iconSize + 2 * _padding);
            Rectangle textRect = new Rectangle(
                _padding,
                0,
                textWidth,
                this.Height
            );

            TextRenderer.DrawText(
                g,
                this.Text,
                this.Font,
                textRect,
                this.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );
        }
    }
}
