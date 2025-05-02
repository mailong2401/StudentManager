namespace StudentManager
{
    partial class UserControlClassShow
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(770, 83);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 31;
            label3.Text = "Tên lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(420, 83);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 30;
            label2.Text = "Tên ngành";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(80, 83);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 28;
            label1.Text = "Tên khoa/viện";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Location = new Point(67, 126);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel1.Size = new Size(1483, 564);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // UserControlClassShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Location = new Point(67, 126);
            Name = "UserControlClassShow";
            Size = new Size(1575, 813);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
