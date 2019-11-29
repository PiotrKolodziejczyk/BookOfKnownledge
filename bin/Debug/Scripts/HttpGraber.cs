using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bukmacher
{
    class HttpGraber
    {
        string baseAdress = "https://apifootball.com/api/?action=get_";
        string apiKey = "APIkey=b548c275c4878941f05213fbfa0f73cc84540b51e15f567e1ad2a67cb50cd59a";
        public string day="10";
        public string month ="02";
        public string day1 = "10";
        public string month1 = "02";
        public string leaqueId = "109";
        public string error = "{\"error\":404,\"message\":\"No event found (please check your plan)!\"}";
        public async Task<List<RootObject>> MakeStringGreatAgain()
        {
            List<RootObject> root=null;
             root= JsonConvert.DeserializeObject<List<RootObject>>(await TestRequest());
            


            return root;
        }
        
        public async Task<string>TestRequest()
        {
            string testRequest=string.Empty;
            try
            {
                var request = HttpWebRequest.CreateHttp($"{baseAdress}events&from=2019-{month}-{day}&to=2019-{month1}-{day1}&league_id={leaqueId}&{apiKey}");
                request.Method = WebRequestMethods.Http.Get;
                request.ContentType = "application/json; charset=utf-8";

                await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null).ContinueWith(tak =>
                {
                    var respons = (HttpWebResponse)tak.Result;
                    if (respons.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader responseReader = new StreamReader(respons.GetResponseStream(), Encoding.UTF8);
                        string responesData = responseReader.ReadToEnd();
                        testRequest = responesData.ToString();
                        responseReader.Close();
                        
                        
                    }
                   
                    respons.Close();
                });
            }
            catch
            {
              
            }


            return testRequest;
        }
    }
}
