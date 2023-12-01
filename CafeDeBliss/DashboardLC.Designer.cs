namespace CafeDeBliss
{
    partial class DashboardLC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardLC));
            this.panel1LC = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLCExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReviewsLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOutLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOrderLC = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrderLC = new Guna.UI2.WinForms.Guna2Button();
            this.panel2LC = new System.Windows.Forms.Panel();
            this.uC_WelcomeLC1 = new CafeDeBliss.AllUserControls.UC_WelcomeLC();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1LC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2LC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1LC
            // 
            this.panel1LC.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1LC.Controls.Add(this.label1);
            this.panel1LC.Controls.Add(this.btnLCExit);
            this.panel1LC.Controls.Add(this.pictureBox1);
            this.panel1LC.Controls.Add(this.btnReviewsLC);
            this.panel1LC.Controls.Add(this.btnLogOutLC);
            this.panel1LC.Controls.Add(this.btnCheckOrderLC);
            this.panel1LC.Controls.Add(this.btnPlaceOrderLC);
            this.panel1LC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LC.Location = new System.Drawing.Point(12, 15);
            this.panel1LC.Name = "panel1LC";
            this.panel1LC.Size = new System.Drawing.Size(323, 744);
            this.panel1LC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loyalty Customer";
            // 
            // btnLCExit
            // 
            this.btnLCExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLCExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLCExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLCExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLCExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLCExit.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLCExit.ForeColor = System.Drawing.Color.White;
            this.btnLCExit.Location = new System.Drawing.Point(0, 0);
            this.btnLCExit.Name = "btnLCExit";
            this.btnLCExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLCExit.Size = new System.Drawing.Size(61, 68);
            this.btnLCExit.TabIndex = 5;
            this.btnLCExit.Text = "X";
            this.btnLCExit.Click += new System.EventHandler(this.btnLCExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnReviewsLC
            // 
            this.btnReviewsLC.BorderRadius = 20;
            this.btnReviewsLC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReviewsLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewsLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewsLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReviewsLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReviewsLC.FillColor = System.Drawing.Color.Gray;
            this.btnReviewsLC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewsLC.ForeColor = System.Drawing.Color.White;
            this.btnReviewsLC.Location = new System.Drawing.Point(70, 517);
            this.btnReviewsLC.Name = "btnReviewsLC";
            this.btnReviewsLC.Size = new System.Drawing.Size(305, 79);
            this.btnReviewsLC.TabIndex = 3;
            this.btnReviewsLC.Text = "Reviews ";
            this.btnReviewsLC.Click += new System.EventHandler(this.btnReviewsLC_Click);
            // 
            // btnLogOutLC
            // 
            this.btnLogOutLC.BorderRadius = 20;
            this.btnLogOutLC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOutLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOutLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOutLC.FillColor = System.Drawing.Color.Gray;
            this.btnLogOutLC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutLC.ForeColor = System.Drawing.Color.White;
            this.btnLogOutLC.Location = new System.Drawing.Point(67, 615);
            this.btnLogOutLC.Name = "btnLogOutLC";
            this.btnLogOutLC.Size = new System.Drawing.Size(305, 79);
            this.btnLogOutLC.TabIndex = 2;
            this.btnLogOutLC.Text = "Log Out";
            this.btnLogOutLC.Click += new System.EventHandler(this.btnLogOutLC_Click);
            // 
            // btnCheckOrderLC
            // 
            this.btnCheckOrderLC.BorderRadius = 20;
            this.btnCheckOrderLC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOrderLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOrderLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOrderLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOrderLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOrderLC.FillColor = System.Drawing.Color.Gray;
            this.btnCheckOrderLC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOrderLC.ForeColor = System.Drawing.Color.White;
            this.btnCheckOrderLC.Location = new System.Drawing.Point(70, 425);
            this.btnCheckOrderLC.Name = "btnCheckOrderLC";
            this.btnCheckOrderLC.Size = new System.Drawing.Size(305, 75);
            this.btnCheckOrderLC.TabIndex = 1;
            this.btnCheckOrderLC.Text = "Check Order";
            this.btnCheckOrderLC.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnPlaceOrderLC
            // 
            this.btnPlaceOrderLC.BorderRadius = 20;
            this.btnPlaceOrderLC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrderLC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrderLC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrderLC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrderLC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrderLC.FillColor = System.Drawing.Color.Gray;
            this.btnPlaceOrderLC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrderLC.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrderLC.Location = new System.Drawing.Point(70, 326);
            this.btnPlaceOrderLC.Name = "btnPlaceOrderLC";
            this.btnPlaceOrderLC.Size = new System.Drawing.Size(287, 74);
            this.btnPlaceOrderLC.TabIndex = 0;
            this.btnPlaceOrderLC.Text = "Place Order";
            this.btnPlaceOrderLC.Click += new System.EventHandler(this.btnPlaceOrderLC_Click);
            // 
            // panel2LC
            // 
            this.panel2LC.BackColor = System.Drawing.Color.LightGray;
            this.panel2LC.Controls.Add(this.uC_WelcomeLC1);
            this.panel2LC.Location = new System.Drawing.Point(324, 15);
            this.panel2LC.Name = "panel2LC";
            this.panel2LC.Size = new System.Drawing.Size(1045, 744);
            this.panel2LC.TabIndex = 1;
            this.panel2LC.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_WelcomeLC1
            // 
            this.uC_WelcomeLC1.BackColor = System.Drawing.Color.White;
            this.uC_WelcomeLC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_WelcomeLC1.BackgroundImage")));
            this.uC_WelcomeLC1.Location = new System.Drawing.Point(3, -3);
            this.uC_WelcomeLC1.Name = "uC_WelcomeLC1";
            this.uC_WelcomeLC1.Size = new System.Drawing.Size(1045, 747);
            this.uC_WelcomeLC1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel1LC;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2LC;
            // 
            // DashboardLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1381, 777);
            this.Controls.Add(this.panel2LC);
            this.Controls.Add(this.panel1LC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardLC";
            this.panel1LC.ResumeLayout(false);
            this.panel1LC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2LC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1LC;
        private System.Windows.Forms.Panel panel2LC;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrderLC;
        private Guna.UI2.WinForms.Guna2Button btnReviewsLC;
        private Guna.UI2.WinForms.Guna2Button btnLogOutLC;
        private Guna.UI2.WinForms.Guna2Button btnCheckOrderLC;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnLCExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_WelcomeLC uC_WelcomeLC1;
    }
}