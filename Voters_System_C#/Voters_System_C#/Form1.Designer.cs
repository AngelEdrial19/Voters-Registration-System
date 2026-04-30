namespace Voters_System_C_
{
    partial class Form1
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
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panelmain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_notification = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Hide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Show = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btn_notification);
            this.guna2Panel1.Controls.Add(this.btn_Register);
            this.guna2Panel1.Controls.Add(this.btnHome);
            this.guna2Panel1.Controls.Add(this.btn_Hide);
            this.guna2Panel1.Controls.Add(this.btn_Show);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(51, 466);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(9, 78);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(127, 13);
            this.guna2Separator1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voter Registration";
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation4;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.panelmain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.ForeColor = System.Drawing.SystemColors.Control;
            this.panelmain.Location = new System.Drawing.Point(51, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(672, 466);
            this.panelmain.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnLogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.Maroon;
            this.btnLogout.Image = global::Voters_System_C_.Properties.Resources.logout__1_;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(8, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "            Log Out";
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_notification
            // 
            this.btn_notification.Animated = true;
            this.btn_notification.AutoRoundedCorners = true;
            this.btn_notification.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btn_notification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_notification.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_notification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_notification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_notification.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_notification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_notification.FillColor = System.Drawing.Color.Transparent;
            this.btn_notification.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_notification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_notification.ForeColor = System.Drawing.Color.White;
            this.btn_notification.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_notification.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_notification.Image = global::Voters_System_C_.Properties.Resources.bell;
            this.btn_notification.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_notification.Location = new System.Drawing.Point(9, 248);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(168, 45);
            this.btn_notification.TabIndex = 6;
            this.btn_notification.Text = "       Notification";
            this.btn_notification.UseTransparentBackground = true;
            this.btn_notification.Click += new System.EventHandler(this.btn_notification_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Animated = true;
            this.btn_Register.AutoRoundedCorners = true;
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btn_Register, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Register.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Register.FillColor = System.Drawing.Color.Transparent;
            this.btn_Register.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btn_Register.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Register.Image = global::Voters_System_C_.Properties.Resources.document;
            this.btn_Register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Register.Location = new System.Drawing.Point(9, 197);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(168, 45);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "           Register Voters";
            this.btn_Register.UseTransparentBackground = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.FillColor2 = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnHome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Image = global::Voters_System_C_.Properties.Resources._3d_house;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(8, 146);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(169, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Animated = true;
            this.btn_Hide.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btn_Hide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Hide.FillColor = System.Drawing.Color.DimGray;
            this.btn_Hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Hide.ForeColor = System.Drawing.Color.White;
            this.btn_Hide.Image = global::Voters_System_C_.Properties.Resources.list__1_;
            this.btn_Hide.Location = new System.Drawing.Point(9, 8);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.PressedColor = System.Drawing.Color.DimGray;
            this.btn_Hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Hide.Size = new System.Drawing.Size(35, 37);
            this.btn_Hide.TabIndex = 4;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Animated = true;
            this.btn_Show.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Transition1.SetDecoration(this.btn_Show, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Show.FillColor = System.Drawing.Color.DimGray;
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Image = global::Voters_System_C_.Properties.Resources.list__1_;
            this.btn_Show.Location = new System.Drawing.Point(9, 8);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.PressedColor = System.Drawing.Color.DimGray;
            this.btn_Show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Show.Size = new System.Drawing.Size(35, 37);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(723, 466);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Show;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Hide;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelmain;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btn_notification;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Register;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}

