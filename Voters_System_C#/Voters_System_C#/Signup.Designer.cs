namespace Voters_System_C_
{
    partial class Signup
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.btnCreateAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chckboxShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtCreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreateUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin.LinkColor = System.Drawing.Color.Lime;
            this.linkLogin.Location = new System.Drawing.Point(161, 302);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(37, 13);
            this.linkLogin.TabIndex = 8;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Log In";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Animated = true;
            this.btnCreateAccount.AutoRoundedCorners = true;
            this.btnCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnCreateAccount.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("Lucida Fax", 9F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAccount.Location = new System.Drawing.Point(111, 217);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(133, 44);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseTransparentBackground = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Already have a account?";
            // 
            // chckboxShowPass
            // 
            this.chckboxShowPass.AutoSize = true;
            this.chckboxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.chckboxShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckboxShowPass.CheckedState.BorderRadius = 0;
            this.chckboxShowPass.CheckedState.BorderThickness = 0;
            this.chckboxShowPass.CheckedState.FillColor = System.Drawing.Color.Black;
            this.chckboxShowPass.CheckMarkColor = System.Drawing.Color.Lime;
            this.chckboxShowPass.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.chckboxShowPass.ForeColor = System.Drawing.Color.White;
            this.chckboxShowPass.Location = new System.Drawing.Point(167, 180);
            this.chckboxShowPass.Name = "chckboxShowPass";
            this.chckboxShowPass.Size = new System.Drawing.Size(115, 18);
            this.chckboxShowPass.TabIndex = 3;
            this.chckboxShowPass.Text = "Show Password";
            this.chckboxShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckboxShowPass.UncheckedState.BorderRadius = 0;
            this.chckboxShowPass.UncheckedState.BorderThickness = 0;
            this.chckboxShowPass.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.chckboxShowPass.UseVisualStyleBackColor = false;
            this.chckboxShowPass.CheckedChanged += new System.EventHandler(this.chckboxShowPass_CheckedChanged);
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Animated = true;
            this.txtCreatePassword.AutoRoundedCorners = true;
            this.txtCreatePassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCreatePassword.BorderColor = System.Drawing.Color.Black;
            this.txtCreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreatePassword.DefaultText = "";
            this.txtCreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreatePassword.Location = new System.Drawing.Point(73, 134);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreatePassword.PlaceholderText = "Create password";
            this.txtCreatePassword.SelectedText = "";
            this.txtCreatePassword.Size = new System.Drawing.Size(208, 36);
            this.txtCreatePassword.TabIndex = 2;
            this.txtCreatePassword.UseSystemPasswordChar = true;
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Animated = true;
            this.txtCreateUsername.AutoRoundedCorners = true;
            this.txtCreateUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtCreateUsername.BorderColor = System.Drawing.Color.Black;
            this.txtCreateUsername.BorderRadius = 19;
            this.txtCreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateUsername.DefaultText = "";
            this.txtCreateUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreateUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreateUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreateUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateUsername.Location = new System.Drawing.Point(74, 85);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreateUsername.PlaceholderText = "Create username";
            this.txtCreateUsername.SelectedText = "";
            this.txtCreateUsername.Size = new System.Drawing.Size(208, 40);
            this.txtCreateUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.linkLogin);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtCreateUsername);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCreateAccount);
            this.guna2CustomGradientPanel1.Controls.Add(this.chckboxShowPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtCreatePassword);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(43)))), ((int)(((byte)(31)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(43)))), ((int)(((byte)(31)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(43)))), ((int)(((byte)(31)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(207, 59);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(347, 346);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(666, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(28, 27);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(694, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 27);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voters_System_C_.Properties.Resources.Gemini_Generated_Image_6o2mnq6o2mnq6o2m;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 466);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateAccount;
        private Guna.UI2.WinForms.Guna2CheckBox chckboxShowPass;
        private Guna.UI2.WinForms.Guna2TextBox txtCreatePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCreateUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}