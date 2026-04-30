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
            try
            {
                var voter = new
                {
                    firstname = txtFirstname.Text,
                    lastname = txtLastname.Text,
                    address = txtAddress.Text,
                    age = int.Parse(txtAge.Text),
                    birthdate = DateTimePicker.Value.ToString("yyyy-MM-dd"),
                    gender = cmbGender.Text,
                    precinct_id = int.Parse(cmbPrecinct.SelectedValue.ToString())
                };

                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(voter);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://127.0.0.1:3000/api/voters", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Voter Registered Successfully!");

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to save data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

       

    }
}
