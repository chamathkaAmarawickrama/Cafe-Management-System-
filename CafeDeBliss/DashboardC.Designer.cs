namespace CafeDeBliss
{
    partial class DashboardC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardC));
            this.panel1C = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReviewC = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOutC = new Guna.UI2.WinForms.Guna2Button();
            this.btnCOrderC = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOrderC = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitC = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2C = new System.Windows.Forms.Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.uC_WelcomeC1 = new CafeDeBliss.AllUserControls.UC_WelcomeC();
            this.panel1C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2C.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1C
            // 
            this.panel1C.BackColor = System.Drawing.Color.Silver;
            this.panel1C.Controls.Add(this.guna2Button1);
            this.panel1C.Controls.Add(this.label1);
            this.panel1C.Controls.Add(this.btnReviewC);
            this.panel1C.Controls.Add(this.btnLogOutC);
            this.panel1C.Controls.Add(this.btnCOrderC);
            this.panel1C.Controls.Add(this.btnPOrderC);
            this.panel1C.Controls.Add(this.pictureBox1);
            this.panel1C.Controls.Add(this.btnExitC);
            this.panel1C.Location = new System.Drawing.Point(31, 21);
            this.panel1C.Name = "panel1C";
            this.panel1C.Size = new System.Drawing.Size(352, 772);
            this.panel1C.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer";
            // 
            // btnReviewC
            // 
            this.btnReviewC.BorderRadius = 20;
            this.btnReviewC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReviewC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReviewC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReviewC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReviewC.FillColor = System.Drawing.Color.Gray;
            this.btnReviewC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewC.ForeColor = System.Drawing.Color.White;
            this.btnReviewC.Location = new System.Drawing.Point(71, 590);
            this.btnReviewC.Name = "btnReviewC";
            this.btnReviewC.Size = new System.Drawing.Size(312, 64);
            this.btnReviewC.TabIndex = 5;
            this.btnReviewC.Text = "Reviews";
            this.btnReviewC.Click += new System.EventHandler(this.btnReviewC_Click);
            // 
            // btnLogOutC
            // 
            this.btnLogOutC.BorderRadius = 20;
            this.btnLogOutC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOutC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOutC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOutC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOutC.FillColor = System.Drawing.Color.Gray;
            this.btnLogOutC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutC.ForeColor = System.Drawing.Color.White;
            this.btnLogOutC.Location = new System.Drawing.Point(71, 671);
            this.btnLogOutC.Name = "btnLogOutC";
            this.btnLogOutC.Size = new System.Drawing.Size(312, 65);
            this.btnLogOutC.TabIndex = 4;
            this.btnLogOutC.Text = "Log Out";
            this.btnLogOutC.Click += new System.EventHandler(this.btnLogOutC_Click);
            // 
            // btnCOrderC
            // 
            this.btnCOrderC.BorderRadius = 20;
            this.btnCOrderC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCOrderC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCOrderC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCOrderC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCOrderC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCOrderC.FillColor = System.Drawing.Color.Gray;
            this.btnCOrderC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOrderC.ForeColor = System.Drawing.Color.White;
            this.btnCOrderC.Location = new System.Drawing.Point(71, 421);
            this.btnCOrderC.Name = "btnCOrderC";
            this.btnCOrderC.Size = new System.Drawing.Size(312, 72);
            this.btnCOrderC.TabIndex = 3;
            this.btnCOrderC.Text = "Check Order";
            this.btnCOrderC.Click += new System.EventHandler(this.btnCOrderC_Click);
            // 
            // btnPOrderC
            // 
            this.btnPOrderC.BorderRadius = 20;
            this.btnPOrderC.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPOrderC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOrderC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOrderC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOrderC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOrderC.FillColor = System.Drawing.Color.Gray;
            this.btnPOrderC.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOrderC.ForeColor = System.Drawing.Color.White;
            this.btnPOrderC.Location = new System.Drawing.Point(71, 341);
            this.btnPOrderC.Name = "btnPOrderC";
            this.btnPOrderC.Size = new System.Drawing.Size(312, 64);
            this.btnPOrderC.TabIndex = 2;
            this.btnPOrderC.Text = "Place Order";
            this.btnPOrderC.Click += new System.EventHandler(this.btnPOrderC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitC
            // 
            this.btnExitC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitC.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitC.ForeColor = System.Drawing.Color.White;
            this.btnExitC.Location = new System.Drawing.Point(4, 4);
            this.btnExitC.Name = "btnExitC";
            this.btnExitC.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExitC.Size = new System.Drawing.Size(61, 64);
            this.btnExitC.TabIndex = 0;
            this.btnExitC.Text = "X";
            this.btnExitC.Click += new System.EventHandler(this.btnExitC_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1C;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2C;
            // 
            // panel2C
            // 
            this.panel2C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2C.Controls.Add(this.uC_WelcomeC1);
            this.panel2C.Location = new System.Drawing.Point(381, 20);
            this.panel2C.Name = "panel2C";
            this.panel2C.Size = new System.Drawing.Size(1038, 780);
            this.panel2C.TabIndex = 1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(71, 509);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(312, 65);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Register";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // uC_WelcomeC1
            // 
            this.uC_WelcomeC1.BackColor = System.Drawing.Color.White;
            this.uC_WelcomeC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_WelcomeC1.BackgroundImage")));
            this.uC_WelcomeC1.Location = new System.Drawing.Point(-4, 1);
            this.uC_WelcomeC1.Name = "uC_WelcomeC1";
            this.uC_WelcomeC1.Size = new System.Drawing.Size(1042, 779);
            this.uC_WelcomeC1.TabIndex = 0;
            // 
            // DashboardC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1448, 823);
            this.Controls.Add(this.panel2C);
            this.Controls.Add(this.panel1C);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DasboardC";
            this.panel1C.ResumeLayout(false);
            this.panel1C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2C.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1C;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExitC;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnReviewC;
        private Guna.UI2.WinForms.Guna2Button btnLogOutC;
        private Guna.UI2.WinForms.Guna2Button btnCOrderC;
        private Guna.UI2.WinForms.Guna2Button btnPOrderC;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel2C;
        private AllUserControls.UC_WelcomeC uC_WelcomeC1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}