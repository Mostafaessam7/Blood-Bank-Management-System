namespace BBMS
{
    partial class BloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodStock));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DBGroupCb = new ComboBox();
            label22 = new Label();
            BloodStockDVG = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BloodStockDVG).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 611);
            panel1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 544);
            label10.Name = "label10";
            label10.Size = new Size(121, 38);
            label10.TabIndex = 16;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(12, 479);
            label11.Name = "label11";
            label11.Size = new Size(154, 35);
            label11.TabIndex = 14;
            label11.Text = "Dashboard";
            label11.Click += label11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 418);
            label8.Name = "label8";
            label8.Size = new Size(215, 35);
            label8.TabIndex = 12;
            label8.Text = "Blood Transfert";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(12, 359);
            label9.Name = "label9";
            label9.Size = new Size(169, 35);
            label9.TabIndex = 10;
            label9.Text = "Blood Stock";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 293);
            label6.Name = "label6";
            label6.Size = new Size(187, 35);
            label6.TabIndex = 8;
            label6.Text = "View Patients";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 231);
            label7.Name = "label7";
            label7.Size = new Size(117, 35);
            label7.TabIndex = 6;
            label7.Text = "Patients";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(105, 35);
            label3.TabIndex = 4;
            label3.Text = "Donate";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(177, 35);
            label5.TabIndex = 6;
            label5.Text = "View Donors";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(95, 35);
            label2.TabIndex = 2;
            label2.Text = "Donor";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(565, 72);
            label4.Name = "label4";
            label4.Size = new Size(192, 38);
            label4.TabIndex = 45;
            label4.Text = "Blood Stock";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(244, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 68);
            panel2.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Navy;
            label12.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(775, 9);
            label12.Name = "label12";
            label12.Size = new Size(30, 29);
            label12.TabIndex = 11;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(501, 38);
            label1.TabIndex = 1;
            label1.Text = "Blood Bank Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 141);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // DBGroupCb
            // 
            DBGroupCb.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DBGroupCb.ForeColor = Color.Navy;
            DBGroupCb.FormattingEnabled = true;
            DBGroupCb.Items.AddRange(new object[] { "A+", "B+", "O+", "AB+", "A-", "B-", "O-", "AB-" });
            DBGroupCb.Location = new Point(540, 275);
            DBGroupCb.Margin = new Padding(3, 4, 3, 4);
            DBGroupCb.Name = "DBGroupCb";
            DBGroupCb.Size = new Size(241, 25);
            DBGroupCb.TabIndex = 67;
            DBGroupCb.SelectedIndexChanged += DBGroupCb_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Navy;
            label22.Location = new Point(320, 275);
            label22.Name = "label22";
            label22.Size = new Size(81, 32);
            label22.TabIndex = 66;
            label22.Text = "Filter";
            // 
            // BloodStockDVG
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            BloodStockDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BloodStockDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BloodStockDVG.ColumnHeadersHeight = 28;
            BloodStockDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BloodStockDVG.DefaultCellStyle = dataGridViewCellStyle3;
            BloodStockDVG.GridColor = Color.FromArgb(231, 229, 255);
            BloodStockDVG.Location = new Point(320, 335);
            BloodStockDVG.Margin = new Padding(3, 4, 3, 4);
            BloodStockDVG.Name = "BloodStockDVG";
            BloodStockDVG.RowHeadersVisible = false;
            BloodStockDVG.RowHeadersWidth = 51;
            BloodStockDVG.RowTemplate.Height = 25;
            BloodStockDVG.Size = new Size(707, 247);
            BloodStockDVG.TabIndex = 69;
            BloodStockDVG.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BloodStockDVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            BloodStockDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BloodStockDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BloodStockDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BloodStockDVG.ThemeStyle.BackColor = Color.White;
            BloodStockDVG.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BloodStockDVG.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BloodStockDVG.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BloodStockDVG.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            BloodStockDVG.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BloodStockDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BloodStockDVG.ThemeStyle.HeaderStyle.Height = 28;
            BloodStockDVG.ThemeStyle.ReadOnly = false;
            BloodStockDVG.ThemeStyle.RowsStyle.BackColor = Color.White;
            BloodStockDVG.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BloodStockDVG.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            BloodStockDVG.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BloodStockDVG.ThemeStyle.RowsStyle.Height = 25;
            BloodStockDVG.ThemeStyle.RowsStyle.SelectionBackColor = Color.Tomato;
            BloodStockDVG.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // BloodStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 611);
            Controls.Add(BloodStockDVG);
            Controls.Add(DBGroupCb);
            Controls.Add(label22);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BloodStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodStock";
            Load += BloodStock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BloodStockDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox DBGroupCb;
        private Label label22;
        private Guna.UI2.WinForms.Guna2DataGridView BloodStockDVG;
        private Label label12;
    }
}