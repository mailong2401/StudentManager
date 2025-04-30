namespace StudentManager
{
    partial class fStudent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBoxNganh = new ComboBox();
            comboBoxKhoa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1234, 249);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(68, 36);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Xem điểm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(868, 36);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "khoa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(686, 36);
            button3.Name = "button3";
            button3.Size = new Size(152, 34);
            button3.TabIndex = 3;
            button3.Text = "Ngành";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(513, 36);
            button4.Name = "button4";
            button4.Size = new Size(152, 34);
            button4.TabIndex = 4;
            button4.Text = "lớp";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(202, 36);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 5;
            button5.Text = "SinhVien";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(335, 36);
            button6.Name = "button6";
            button6.Size = new Size(152, 34);
            button6.TabIndex = 6;
            button6.Text = "môn học";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBoxNganh
            // 
            comboBoxNganh.FormattingEnabled = true;
            comboBoxNganh.Location = new Point(686, 102);
            comboBoxNganh.Name = "comboBoxNganh";
            comboBoxNganh.Size = new Size(182, 33);
            comboBoxNganh.TabIndex = 7;
            comboBoxNganh.SelectedIndexChanged += comboBoxNganh_SelectedIndexChanged;
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Location = new Point(488, 101);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(182, 33);
            comboBoxKhoa.TabIndex = 8;
            comboBoxKhoa.SelectedIndexChanged += comboBoxKhoa_SelectedIndexChanged;
            // 
            // fStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 607);
            Controls.Add(comboBoxKhoa);
            Controls.Add(comboBoxNganh);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "fStudent";
            Text = "fStudent";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBoxNganh;
        private ComboBox comboBoxKhoa;
    }
}