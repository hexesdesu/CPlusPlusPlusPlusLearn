using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Text.RegularExpressions;

namespace Zentao
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://zentao.dmsd.tech/zentao/task-view-5442.json");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "device=desktop; lang=zh-cn; lastProject=83; theme=default; zentaosid=pj2qq6h6enpkqmbd0qknq6hn40");
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
           

            JObject jo1 = (JObject)JsonConvert.DeserializeObject(response.Content);
            //string zone = jo1["beijing"]["zone"].ToString();
            //string zone_en = jo1["beijing"]["zone_en"].ToString();
            //Console.WriteLine(jo1);
            string s = Unicode2String(jo1.ToString()).Replace(@"\", @"");

            Console.WriteLine( s);

            Console.ReadKey();
        }

        internal static string Unicode2String(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(source, x => Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)).ToString());
        }
    }
}
