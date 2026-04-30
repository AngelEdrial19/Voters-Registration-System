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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var data = new
            {
                username = txtUsername.Text,
                password = txtPassword.Text
            };

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://127.0.0.1:3000/api/login", content);

            var result = await response.Content.ReadAsStringAsync();
            dynamic res = JsonConvert.DeserializeObject(result);

            if (res.success == true)
            {
                // 🔥 SAVE USER ID
                Properties.Settings.Default.UserId = (int)res.user_id;
                Properties.Settings.Default.Save();

                MessageBox.Show("Login successful");

                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
    }
}
