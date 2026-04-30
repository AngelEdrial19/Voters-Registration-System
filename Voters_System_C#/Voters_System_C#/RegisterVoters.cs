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
    public partial class RegisterVoters : UserControl
    {
        public RegisterVoters()
        {
            InitializeComponent();
        }

        private void RegisterVoters_Load(object sender, EventArgs e)
        {
            LoadPrecincts();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var data = new
            {
                firstname = txtFirstname.Text,
                lastname = txtLastname.Text,
                address = txtAddress.Text,
                age = int.Parse(txtAge.Text),
                birthdate = DateTimePicker.Value.ToString("yyyy-MM-dd"),
                gender = cmbGender.Text,
                precinct_id = cmbPrecinct.SelectedValue,
                status = "pending" // 🔥 IMPORTANT
                user_id = Properties.Settings.Default.UserId
            };

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://127.0.0.1:3000/api/voters", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registered successfully! Waiting for approval.");

                // 🔥 save fullname (temporary login identity)
                Properties.Settings.Default.FullName = txtFirstname.Text + " " + txtLastname.Text;
                Properties.Settings.Default.Save();

                ClearFields();
            }
            else
            {
                MessageBox.Show("Error saving data");
            }
        }

        private void ClearFields()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbPrecinct.SelectedIndex = -1;
        }

        private void cmbPrecinct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void LoadPrecincts()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("http://127.0.0.1:3000/api/precincts");

            var data = JsonConvert.DeserializeObject<List<Precinct>>(response);

            cmbPrecinct.DataSource = data;
            cmbPrecinct.DisplayMember = "precinct_no";
            cmbPrecinct.ValueMember = "precinct_id";
        }

        public class Precinct
        {
            public int precinct_id { get; set; }
            public string precinct_no { get; set; }
        }

        public class Voter
        {
            public int voter_id { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string status { get; set; }
        }


    }
}
