namespace CafeDeBliss
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnSR = new Guna.UI2.WinForms.Guna2Button();
            this.btnRR = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnItemsReport = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnItemsReport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSR);
            this.panel1.Controls.Add(this.btnRR);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 769);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(68, 71);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSR
            // 
            this.btnSR.BackColor = System.Drawing.Color.Transparent;
            this.btnSR.BorderRadius = 30;
            this.btnSR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSR.FillColor = System.Drawing.Color.LightGray;
            this.btnSR.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSR.ForeColor = System.Drawing.Color.Black;
            this.btnSR.Location = new System.Drawing.Point(52, 538);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(273, 74);
            this.btnSR.TabIndex = 3;
            this.btnSR.Text = "Sales Report";
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnRR
            // 
            this.btnRR.BackColor = System.Drawing.Color.Transparent;
            this.btnRR.BorderRadius = 30;
            this.btnRR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRR.FillColor = System.Drawing.Color.LightGray;
            this.btnRR.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRR.ForeColor = System.Drawing.Color.Black;
            this.btnRR.Location = new System.Drawing.Point(52, 416);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(273, 70);
            this.btnRR.TabIndex = 2;
            this.btnRR.Text = "Reviews Report";
            this.btnRR.Click += new System.EventHandler(this.btnRR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(384, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 769);
            this.panel2.TabIndex = 1;
            // 
            // btnItemsReport
            // 
            this.btnItemsReport.BackColor = System.Drawing.Color.Transparent;
            this.btnItemsReport.BorderRadius = 30;
            this.btnItemsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItemsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItemsReport.FillColor = System.Drawing.Color.LightGray;
            this.btnItemsReport.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsReport.ForeColor = System.Drawing.Color.Black;
            this.btnItemsReport.Location = new System.Drawing.Point(52, 657);
            this.btnItemsReport.Name = "btnItemsReport";
            this.btnItemsReport.Size = new System.Drawing.Size(273, 74);
            this.btnItemsReport.TabIndex = 4;
            this.btnItemsReport.Text = "Items Report";
            this.btnItemsReport.Click += new System.EventHandler(this.btnItemsReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1426, 818);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSR;
        private Guna.UI2.WinForms.Guna2Button btnRR;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnItemsReport;
    }
}