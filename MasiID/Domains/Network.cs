using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MasiID.Domains
{
    public class Network
    {

        private const string API_URL_REGISTER = "http://192.168.3.143:5000/register";

        public static async Task SendDataToApiAsync(string userData, byte[] signature, X509Certificate2 cert)
        {
            var client = new HttpClient();

            var content = new StringContent(userData, Encoding.UTF8, "application/json");

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, API_URL_REGISTER)
            {
                Content = content
            };

            requestMessage.Headers.Add("X-Signature", Convert.ToBase64String(signature));
            requestMessage.Headers.Add("X-Certificate", Convert.ToBase64String(cert.GetPublicKey()));

            try
            {
                var response = await client.SendAsync(requestMessage);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data sent successfully");
                }
                else
                {
                    MessageBox.Show($"Error during sending: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
    }

}
