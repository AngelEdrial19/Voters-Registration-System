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
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
            LoadNotification();
        }

        public class Voter
        {
            public int voter_id { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string status { get; set; }
            public int user_id { get; set; }
        }

        private async void LoadNotification()
        {
            try
            {
                var client = new HttpClient();

                var response = await client.GetStringAsync("http://127.0.0.1:3000/api/voters");

                var voters = JsonConvert.DeserializeObject<List<Voter>>(response);

                string fullname = Properties.Settings.Default.FullName;

                var user = voters.FirstOrDefault(v => v.user_id == Properties.Settings.Default.UserId);

                if (user != null)
                {
                    if (user.status == "approved")
                    {
                        lblMessage.Text = $"Hi {fullname}, you are now registered as a voter. Thank you!";
                        lblMessage.ForeColor = Color.Green;
                    }
                    else if (user.status == "rejected")
                    {
                        lblMessage.Text = $"Hi {fullname}, your registration was rejected.";
                        lblMessage.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblMessage.Text = $"Hi {fullname}, your registration is still pending.";
                        lblMessage.ForeColor = Color.Orange;
                    }
                }
                else
                {
                    lblMessage.Text = "No registration found.";
                }
            }
            catch
            {
                lblMessage.Text = "Error connecting to server.";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotification();
        }
    }
}
