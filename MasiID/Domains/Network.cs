using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MasiID.Domains
{
    public class Network
    {
        private const string API_URL_REGISTER = "https://192.168.8.55:30444/AMAZI/V1/mazi-id/registerTest";

        public static async Task<bool> SendDataToApiAsync(byte[] userData, byte[] signature, X509Certificate2 cert)
        {
            var handler = new HttpClientHandler()
            {
                SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls,
                // Bypass certificate validation
                ServerCertificateCustomValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
            };

            var client = new HttpClient(handler);

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
