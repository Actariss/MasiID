using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MasiID.Domains
{
    public class Network
    {
        public static async Task SendDataToApiAsync(User user)
        {
            var json = JsonSerializer.Serialize(user);

            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://192.168.91.138:5000/register", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data sended successfully");
                }
                else
                {
                    MessageBox.Show($"Error during sending : {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception : {ex.Message}");
            }
        }
    }
}
