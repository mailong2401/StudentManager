namespace StudentManager
{
    partial class UserControlStudent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudent));
            panelUserControlChild = new Panel();
            panel1 = new Panel();
            btnStudentSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnStudentShow = new ReaLTaiizor.Controls.ParrotButton();
            btnStudentAdd = new ReaLTaiizor.Controls.ParrotButton();
            mainStudent = new Panel();
            panelUserControlChild.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserControlChild
            // 
            panelUserControlChild.BackColor = Color.White;
            panelUserControlChild.Controls.Add(mainStudent);
            panelUserControlChild.Controls.Add(panel1);
            panelUserControlChild.Dock = DockStyle.Fill;
            panelUserControlChild.Location = new Point(0, 0);
            panelUserControlChild.Name = "panelUserControlChild";
            panelUserControlChild.Size = new Size(1575, 900);
            panelUserControlChild.TabIndex = 2;
            panelUserControlChild.Paint += panelUserControlChild_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 25, 30);
            panel1.Controls.Add(btnStudentSearch);
            panel1.Controls.Add(btnStudentShow);
            panel1.Controls.Add(btnStudentAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1575, 87);
            panel1.TabIndex = 1;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentSearch.ButtonImage = (Image)resources.GetObject("btnStudentSearch.ButtonImage");
            btnStudentSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentSearch.ButtonText = "Lọc";
            btnStudentSearch.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentSearch.ClickTextColor = Color.DodgerBlue;
            btnStudentSearch.CornerRadius = 40;
            btnStudentSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentSearch.Horizontal_Alignment = StringAlignment.Center;
            btnStudentSearch.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentSearch.HoverTextColor = Color.DodgerBlue;
            btnStudentSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentSearch.Location = new Point(1083, 4);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(303, 79);
            btnStudentSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentSearch.TabIndex = 5;
            btnStudentSearch.TextColor = Color.White;
            btnStudentSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentSearch.Vertical_Alignment = StringAlignment.Center;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // btnStudentShow
            // 
            btnStudentShow.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentShow.ButtonImage = (Image)resources.GetObject("btnStudentShow.ButtonImage");
            btnStudentShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentShow.ButtonText = "Xem";
            btnStudentShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentShow.ClickTextColor = Color.DodgerBlue;
            btnStudentShow.CornerRadius = 40;
            btnStudentShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentShow.Horizontal_Alignment = StringAlignment.Center;
            btnStudentShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentShow.HoverTextColor = Color.DodgerBlue;
            btnStudentShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentShow.Location = new Point(623, 4);
            btnStudentShow.Name = "btnStudentShow";
            btnStudentShow.Size = new Size(303, 79);
            btnStudentShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentShow.TabIndex = 4;
            btnStudentShow.TextColor = Color.White;
            btnStudentShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentShow.Vertical_Alignment = StringAlignment.Center;
            btnStudentShow.Click += btnStudentShow_Click;
            // 
            // btnStudentAdd
            // 
            btnStudentAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentAdd.ButtonImage = (Image)resources.GetObject("btnStudentAdd.ButtonImage");
            btnStudentAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentAdd.ButtonText = "Thêm";
            btnStudentAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentAdd.ClickTextColor = Color.DodgerBlue;
            btnStudentAdd.CornerRadius = 40;
            btnStudentAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentAdd.Horizontal_Alignment = StringAlignment.Center;
            btnStudentAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentAdd.HoverTextColor = Color.DodgerBlue;
            btnStudentAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentAdd.Location = new Point(183, 4);
            btnStudentAdd.Name = "btnStudentAdd";
            btnStudentAdd.RightToLeft = RightToLeft.No;
            btnStudentAdd.Size = new Size(303, 79);
            btnStudentAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentAdd.TabIndex = 3;
            btnStudentAdd.TextColor = Color.White;
            btnStudentAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentAdd.Vertical_Alignment = StringAlignment.Center;
            btnStudentAdd.Click += btnStudentAdd_Click;
            // 
            // mainStudent
            // 
            mainStudent.Dock = DockStyle.Fill;
            mainStudent.Location = new Point(0, 87);
            mainStudent.Name = "mainStudent";
            mainStudent.Size = new Size(1575, 813);
            mainStudent.TabIndex = 2;
            // 
            // UserControlStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelUserControlChild);
            Name = "UserControlStudent";
            Size = new Size(1575, 900);
            panelUserControlChild.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControlChild;
        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotButton btnStudentSearch;
        private ReaLTaiizor.Controls.ParrotButton btnStudentShow;
        private ReaLTaiizor.Controls.ParrotButton btnStudentAdd;
        private Panel mainStudent;
    }
}
