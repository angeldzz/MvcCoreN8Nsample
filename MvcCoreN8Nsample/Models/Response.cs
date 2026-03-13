using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MvcCoreN8Nsample.Models
{
    public class Response
    {
        [JsonProperty("comas")]
        public string DatosBrutos { get; set; }
        [JsonProperty("imagenes")]
        public List<string> Imagenes { get; set; }
    }
}
