namespace StudentManager
{
    partial class UserControlStatistic
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
            panelUserControlChild = new Panel();
            SuspendLayout();
            // 
            // panelUserControlChild
            // 
            panelUserControlChild.BackColor = Color.White;
            panelUserControlChild.Dock = DockStyle.Fill;
            panelUserControlChild.Location = new Point(0, 0);
            panelUserControlChild.Name = "panelUserControlChild";
            panelUserControlChild.Size = new Size(1575, 900);
            panelUserControlChild.TabIndex = 2;
            // 
            // UserControlStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelUserControlChild);
            Name = "UserControlStatistic";
            Size = new Size(1575, 900);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControlChild;
    }
}
