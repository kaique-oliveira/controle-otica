
using Kvision.Dominio.ViewModel;
using Newtonsoft.Json;
using System.Net;

namespace Kvision.Dominio.Servico
{
    public static class ServiceBuscarEndereco
    {

        public static ViewEndereco BuscarEndereco(string cep)
        {
            var requisicaoWeb = WebRequest.CreateHttp($"https://brasilapi.com.br/api/cep/v1/{cep}");
            requisicaoWeb.Method = "GET";

            ViewEndereco endereco = new ViewEndereco();

            try
            {
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    endereco = JsonConvert.DeserializeObject<ViewEndereco>(objResponse.ToString());
                    Console.ReadLine();
                    streamDados.Close();
                    resposta.Close();
                }
            }
            catch (Exception)
            {
                endereco.Street = "erro";
                return endereco;
            }

            return endereco;
        }
    }
}
