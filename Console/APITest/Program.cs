using System;
using Newtonsoft.Json;
using RestSharp;

namespace HelloWorldApplication
{
    internal class HelloWorld
    {
        private static void Main(string[] args)
        {
            var client = new RestClient("https://localhost:7210/category/get-all");
            var request = new RestRequest();
            request.Method = Method.Get;
            RestResponse response = client.Execute(request);
            var formattedJson = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(response.Content), Formatting.Indented);
            Console.WriteLine(formattedJson);
        }
    }
}