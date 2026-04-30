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

            uc.Dock = DockStyle.Fill;
            panelmain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = false;
            btn_Hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 183;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            //guna2PictureBox1.Visible = false;
            guna2Panel1.Visible = false;
            btn_Hide.Visible = false;
            btn_Show.Visible = true;
            guna2Panel1.Width = 52;
            guna2Transition1.ShowSync(guna2Panel1);
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
            Close();
        }

        
    }
    
    
}
