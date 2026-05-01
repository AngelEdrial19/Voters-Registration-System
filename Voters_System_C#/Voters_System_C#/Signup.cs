using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Voters_System_C_
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var data = new
            {
                username = txtCreateUsername.Text,
                password = txtCreatePassword.Text
            };

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://127.0.0.1:3000/api/register", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Account created successfully!");

                // balik sa login
                new Login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error creating account");
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
