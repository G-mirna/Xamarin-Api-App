using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace UsoApiTurismo
{
    public class ApiService
    {
        private HttpClient client;

        public ApiService()
        {
            // Crear un cliente HttpClientHandler
            var handler = new HttpClientHandler();

            // Establecer el callback para la validación del certificado SSL
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                // Retornar true para aceptar todos los certificados (INSEGURO)
                return true;
            };

            // Asignar el handler al cliente HttpClient
            client = new HttpClient(handler);
        }

        public async Task<List<lugares>> GetProductsAsync()
        {
            try
            {
                var response = await client.GetStringAsync("https://localhost:7174/api/Lugar/GetAll");
                var lugares = JsonConvert.DeserializeObject<List<lugares>>(response);
                var products = lugares;
                Console.WriteLine(products);
                return products;
            }
            catch (HttpRequestException ex)
            {
                // Manejar la excepción, por ejemplo, lanzarla nuevamente o devolver una lista vacía
                throw ex;
            }
        }
    }
}
