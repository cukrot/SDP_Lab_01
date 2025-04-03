using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1.Lab4
{
    public partial class frmLab4 : Form
    {
        public frmLab4()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            APICaller apiCaller = new APICaller();
            string response = await apiCaller.GetApiResponse("/api/SimpleGetAPI/SimpleGetMethod");
            label1.Text = response;
        }
        private async Task<String> GetApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // Adjust the base address as needed
                    HttpResponseMessage response = await client.GetAsync("/api/SimpleGetAPI/SimpleGetMethod");

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Log the status code and reason
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        MessageBox.Show(error);
                        return error;

                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                return $"Request error: {e.Message}";
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                return $"An error occurred: {ex.Message}";
            }
        }

    }
}
