using NotificationSalvador.Core.Interface;
using NotificationSalvador.Domain.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace NotificationSalvador.Core
{
    public class FindAvailablesDateForConsultationsService : IFindAvailablesDateForConsultationsService
    {
        public HttpClient _httpClient;
        public readonly string TOKEN_SERVICO_CIDADAO = Environment.GetEnvironmentVariable("BEARER_TOKEN_SERVICO_CIDADAO_BA");
        public FindAvailablesDateForConsultationsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Build_Information_Of_Consultation(List<AvailableItens> availableItens)
        {
            Uri Uri = new("");

        }

        public async Task<List<AvailableItens>> GetAvailables_Date_For_Consultation()
        {
            List<AvailableItens> healthPostAvailables = new();
            
            for (int j = 596; j <= 597; j++)
            {
                for (int i = 4638; i <= 4658; i++)
                {
                    Uri uri = new ($"https://servicosaocidadao.ba.gov.br/api/agendamento/v1/servicos/{i}/postos/{j}/datas");

                    var request = new HttpRequestMessage(HttpMethod.Get, uri);

                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN_SERVICO_CIDADAO);

                    var response = await _httpClient.SendAsync(request);

                    var ResponseAsJson = response.Content.ReadFromJsonAsync<AvailableItens>().Result;

                    healthPostAvailables.Add(ResponseAsJson);
                }
            }
            return healthPostAvailables;
        }
    }
}

