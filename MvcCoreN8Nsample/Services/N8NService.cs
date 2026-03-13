using MvcCoreN8Nsample.Models;
using Newtonsoft.Json;

namespace MvcCoreN8Nsample.Services
{
    public class N8NService
    {
        public async Task<Response> Execute(string web)
        {
            string urlHost = "http://localhost:5678/";
            string request = "webhook/probando";
            using (HttpClient client = new HttpClient())
            {
                Data data = new Data { PaginaWeb = web };
                client.BaseAddress = new Uri(urlHost);
                var response = await client.PostAsJsonAsync(request, data);
                //EXTRAEMOS LOS DATOS DE LA RESPUESTA MAPEANDO 
                //CON LA CLASE RESPONSE
                Response datos = await response.Content.ReadFromJsonAsync<Response>();
                return datos;
            }
        }
    }
}
