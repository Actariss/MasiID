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

        private const string API_URL_REGISTER = "http://127.0.0.1:8080/register";

        public static async Task<bool> SendDataToApiAsync(byte[] userData, byte[] signature, X509Certificate2 cert)
        {
            var client = new HttpClient();

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, API_URL_REGISTER);

            requestMessage.Headers.Add("X-Data", Convert.ToBase64String(userData));
            requestMessage.Headers.Add("X-Signature", Convert.ToBase64String(signature));
            requestMessage.Headers.Add("X-Certificate", Convert.ToBase64String(cert.Export(X509ContentType.Cert)));
           

            try
            {
                var response = await client.SendAsync(requestMessage);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
