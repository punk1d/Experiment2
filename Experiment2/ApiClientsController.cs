using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment2.Models;
using RestSharp;


namespace Experiment2
{
    internal class ApiClientController
    {

        public void CreateClient(ClientModel client)
        {
            var RestClient = new RestClient("http://www.experiment2.io");
            //HttpBasicAuthenticator(username, password);

            var request = new RestRequest("api/clients", Method.POST);

            // easily add HTTP Headers
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(client);

            // execute the request
            IRestResponse response = RestClient.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
        }

    }
}