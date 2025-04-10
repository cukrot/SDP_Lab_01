using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using SDP_EntityModels;

namespace WinFormsApp1.Lab6
{
    public partial class frmRegister : Form
    {
        public bool isLogin = false;
        public frmRegister()
        {
            InitializeComponent();
            isLogin = false;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            int registerUser = await RegisterUser(txtUsername.Text, txtPassword.Text);
            if (registerUser == 1)
            {
                MessageBox.Show("User registered successfully.");
                Close();
            }
            else
            {
                // Handle the error case
            }
        }

        private async Task<int> RegisterUser(String username, String password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);

                    // Create a new instance of LoginRequest and set its properties
                    LoginRequest jsonLoginRequest = new LoginRequest();
                    jsonLoginRequest.username = username;
                    jsonLoginRequest.password = HashPassword(password);
                    string jsonString = JsonConvert.SerializeObject(jsonLoginRequest);

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    // Send POST request to the Web API
                    HttpResponseMessage response = await client.PostAsync("/api/UserLogin/RegisterUser", content);

                    // Ensure the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseString = await response.Content.ReadAsStringAsync();

                        // Parse the response string to an integer
                        int rowsUpdated = int.Parse(responseString);

                        return rowsUpdated;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return 0;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                throw e;
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw ex;
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
