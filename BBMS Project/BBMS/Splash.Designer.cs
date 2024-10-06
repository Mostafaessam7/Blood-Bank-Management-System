namespace BBMS
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            timer1 = new System.Windows.Forms.Timer(components);
            SplashPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SplashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashPanel
            // 
            SplashPanel.Controls.Add(label2);
            SplashPanel.Controls.Add(label1);
            SplashPanel.Controls.Add(pictureBox1);
            SplashPanel.CustomizableEdges = customizableEdges1;
            SplashPanel.FillColor = Color.Navy;
            SplashPanel.FillColor2 = Color.Navy;
            SplashPanel.FillColor3 = Color.Navy;
            SplashPanel.FillColor4 = Color.Navy;
            SplashPanel.Location = new Point(-1, 1);
            SplashPanel.Name = "SplashPanel";
            SplashPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SplashPanel.Size = new Size(1087, 505);
            SplashPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(441, 115);
            label2.Name = "label2";
            label2.Size = new Size(178, 42);
            label2.TabIndex = 2;
            label2.Text = "Welcome !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(228, 33);
            label1.Name = "label1";
            label1.Size = new Size(616, 48);
            label1.TabIndex = 1;
            label1.Text = "Blood Bank System Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1087, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 506);
            Controls.Add(SplashPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            SplashPanel.ResumeLayout(false);
            SplashPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SplashPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}