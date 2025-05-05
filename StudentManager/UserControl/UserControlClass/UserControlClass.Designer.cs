namespace StudentManager
{
    partial class UserControlClass
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
            mainclass = new Panel();
            panelUserControlChild.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserControlChild
            // 
            panelUserControlChild.BackColor = Color.White;
            panelUserControlChild.Controls.Add(mainclass);
            panelUserControlChild.Dock = DockStyle.Fill;
            panelUserControlChild.Location = new Point(0, 0);
            panelUserControlChild.Name = "panelUserControlChild";
            panelUserControlChild.Size = new Size(1575, 900);
            panelUserControlChild.TabIndex = 2;
            // 
            // mainclass
            // 
            mainclass.Dock = DockStyle.Fill;
            mainclass.Location = new Point(0, 0);
            mainclass.Name = "mainclass";
            mainclass.Size = new Size(1575, 900);
            mainclass.TabIndex = 3;
            // 
            // UserControlClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUserControlChild);
            Name = "UserControlClass";
            Size = new Size(1575, 900);
            panelUserControlChild.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelUserControlChild;
        private Panel mainclass;
    }
}
