using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voters_System_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void addUserControl(UserControl uc)
        {
            panelmain.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            panelmain.Controls.Add(uc);
            uc.BringToFront();
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterVoters uc = new RegisterVoters();
            addUserControl(uc);
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            Notification uc = new Notification();
            addUserControl(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // 🔥 balik sa login form
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide(); // or this.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            addUserControl(new Home());
        }
    }
    
    
}
