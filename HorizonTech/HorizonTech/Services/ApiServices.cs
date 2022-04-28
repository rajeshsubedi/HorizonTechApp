using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using HorizonTech.Models;
using Newtonsoft.Json.Linq;

namespace HorizonTech.Services
{
    public class ApiServices
    {
        public async Task<bool> ActivationAsync(
            int Liscence, int Token)
        {
            var client = new HttpClient();

            var model = new ActivationpageModel
            {
                Liscence = Liscence,
                Token = Token,
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(
                "  ", content);                                   /*HttpClient request*/
            return response.IsSuccessStatusCode;

        }
    }


    //public async Task<int> ActivationAsync(int Liscence, int Token)
    //{
    //var keyValues = new List<KeyValuePair<int, int>>
    //    {
    //        new KeyValuePair<int, int>("Liscence", Liscence),
    //        new KeyValuePair<int, int>("Token", Token),
    //    };

    //var request = new HttpRequestMessage(
    //    HttpMethod.Post, "   ");


    //var client = new HttpClient();
    //var response = await client.SendAsync(request);

    //var jwt = await response.Content.ReadAsStringAsync();

    //JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(jwt);

    //Debug.WriteLine(jwt);
    //var accessToken = 0;
    //return accessToken;

    //}


}
