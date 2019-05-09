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
            IRestResponse Response = null;
            var RestClient = new RestClient("http://www.experiment2.io/api/clients");
            var Request = new RestRequest(Method.POST);
            Request.AddHeader("Content-Type", "application/json");
            var Client = new Parameter("Client", client, ParameterType.RequestBody);
            Request.AddParameter(Client);
            //var Password = new Parameter("Password", client.Password, ParameterType.RequestBody);
            //Request.AddParameter(Password);
            //var name = new Parameter("name", client.Name, ParameterType.RequestBody);
            //Request.AddParameter(name);
            //var Lastname = new Parameter("Lastname", client.Lastname, ParameterType.RequestBody);
            //Request.AddParameter(Lastname);
            //var Phone = new Parameter("Phone", client.Phonenumber, ParameterType.RequestBody);
            //Request.AddParameter(Phone);
            //var Email = new Parameter("Email", client.Email, ParameterType.RequestBody);
            //Request.AddParameter(Email);
            try
            {
                Response = RestClient.Execute(Request);
                
                Console.WriteLine(Response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(Response.Content);
        }

    }
}