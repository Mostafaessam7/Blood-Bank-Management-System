namespace BBMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EmpIdTb = new TextBox();
            EmpPassTb = new TextBox();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label5 = new Label();
            LoginPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Times New Roman", 26F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 10);
            label1.Name = "label1";
            label1.Size = new Size(599, 51);
            label1.TabIndex = 1;
            label1.Text = "Blood Bank Management System";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, 108);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(116, 277);
            label2.Name = "label2";
            label2.Size = new Size(154, 35);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // EmpIdTb
            // 
            EmpIdTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            EmpIdTb.ForeColor = Color.Navy;
            EmpIdTb.Location = new Point(366, 277);
            EmpIdTb.Margin = new Padding(3, 4, 3, 4);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(399, 27);
            EmpIdTb.TabIndex = 4;
            EmpIdTb.TextChanged += textBox1_TextChanged;
            // 
            // EmpPassTb
            // 
            EmpPassTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            EmpPassTb.ForeColor = Color.Navy;
            EmpPassTb.Location = new Point(366, 372);
            EmpPassTb.Margin = new Padding(3, 4, 3, 4);
            EmpPassTb.Name = "EmpPassTb";
            EmpPassTb.PasswordChar = '*';
            EmpPassTb.Size = new Size(399, 27);
            EmpPassTb.TabIndex = 6;
            EmpPassTb.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(116, 372);
            label3.Name = "label3";
            label3.Size = new Size(137, 35);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Navy;
            guna2Button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(366, 449);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(399, 47);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Login";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(476, 536);
            label4.Name = "label4";
            label4.Size = new Size(205, 25);
            label4.TabIndex = 8;
            label4.Text = "Continue As Admin";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1045, 10);
            label5.Name = "label5";
            label5.Size = new Size(30, 29);
            label5.TabIndex = 9;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(label5);
            LoginPanel.Controls.Add(label1);
            LoginPanel.CustomizableEdges = customizableEdges3;
            LoginPanel.FillColor = Color.Navy;
            LoginPanel.FillColor2 = Color.Navy;
            LoginPanel.FillColor3 = Color.Navy;
            LoginPanel.FillColor4 = Color.Navy;
            LoginPanel.Location = new Point(0, -1);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LoginPanel.Size = new Size(1087, 84);
            LoginPanel.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 611);
            Controls.Add(LoginPanel);
            Controls.Add(label4);
            Controls.Add(guna2Button1);
            Controls.Add(EmpPassTb);
            Controls.Add(label3);
            Controls.Add(EmpIdTb);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox EmpIdTb;
        private TextBox EmpPassTb;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel LoginPanel;
    }
}