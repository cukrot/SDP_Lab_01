using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public class APICaller
    {
        public async Task<String> GetApiResponse(String endpoint) //String endpoint
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // Adjust the base address as needed
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Log the status code and reason
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
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
        public async Task<DataTable> GetCustomerDataFromApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // Adjust the base address as needed
                    HttpResponseMessage response = await client.GetAsync("/api/SimpleGetAPI/GetCustomerData");

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonString);

                        return dataTable;
                    }
                    else
                    {
                        // Log the status code and reason
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
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

    }
}
