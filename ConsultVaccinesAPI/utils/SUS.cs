using System.Net;
using System;
using Newtonsoft.Json;

namespace ConsultVaccinesAPI.utils
{
    public class SUS
    {
        static void Main()
        {
            string url = "https://covid.saude.gov.br/api/v1/public/indicadores/29/dados";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                dynamic data = JsonConvert.DeserializeObject(json);

                int applyeds = data.dados[0].valor;
                int total = data.dados[1].valor;

                double porcentagem = (double)applyeds / total * 100;
            }
    }

}
}
