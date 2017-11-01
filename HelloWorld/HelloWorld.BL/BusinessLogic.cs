using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Configuration;
namespace HelloWorld.BL
{
    public class BusinessLogic
        {
        
        public string clientBaseAddress = ConfigurationManager.AppSettings["SuperfulfillmentService"].ToString();
        private HttpClient client;

        public string DisplayHelloWorld()
        {
            try
            {
                createClientObject();
                HttpResponseMessage response = client.GetAsync("api/Hello/DisplayMessage").Result;
                if (response.IsSuccessStatusCode)
                {
                    var objResponse = response.Content.ReadAsStringAsync();
                    var jo = JObject.Parse(objResponse.Result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "";
        }
        private void createClientObject()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(clientBaseAddress);
        }
    }
    }
