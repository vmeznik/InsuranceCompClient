using System.Text.Json;
using System.Text;
using System.Runtime.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace InsuranceComp.Shared
{
    public class EmpServiceImpl : IEmpService
    {

        private Client clientInfo;
        public async Task<Client> ClientsInfo(Client insuranceClient)
        {
            clientInfo = null;
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(insuranceClient), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/insuranceComp/clientInfo", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string jsonObj = await response.Content.ReadAsStringAsync();
                clientInfo = JsonSerializer.Deserialize<Client>(jsonObj);
                return clientInfo;
            }
            clientInfo = null;
            return clientInfo;
        }



        public async Task<RequestConfirmation> Login(Employee employee)
        {
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/insuranceComp/loginEmployee", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string jsonObj = await response.Content.ReadAsStringAsync();
                RequestConfirmation requestConfirmation = JsonSerializer.Deserialize<RequestConfirmation>(jsonObj);
                return requestConfirmation;
            }
            else
            {
                var requestConfirmation = new RequestConfirmation(false, "We are sorry server is off ");
                return requestConfirmation;
            }
        }

        public async Task<RequestConfirmation> Register(Employee employee)
        {
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/insuranceComp/registerEmployee", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string jsonObj = await response.Content.ReadAsStringAsync();
                RequestConfirmation requestConfirmation = JsonSerializer.Deserialize<RequestConfirmation>(jsonObj);
                return requestConfirmation;
            }
            else
            {
                var requestConfirmation = new RequestConfirmation(false, "We are sorry server is off ");
                return requestConfirmation;
            }
        }

        public async Task<RequestConfirmation> RegisterClient(Client insuranceClient)
        {
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(insuranceClient), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/insuranceComp/addClient", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string jsonObj = await response.Content.ReadAsStringAsync();
                RequestConfirmation requestConfirmation = JsonSerializer.Deserialize<RequestConfirmation>(jsonObj);
                return requestConfirmation;
            }
            else
            {
                var requestConfirmation = new RequestConfirmation(false, "We are sorry server is off ");
                return requestConfirmation;
            }
        }

        public async Task<RequestConfirmation> UpdateClient(Client insuranceClient)
        {
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonSerializer.Serialize(insuranceClient), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/insuranceComp/updateClient", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                string jsonObj = await response.Content.ReadAsStringAsync();
                RequestConfirmation requestConfirmation = JsonSerializer.Deserialize<RequestConfirmation>(jsonObj);
                return requestConfirmation;
            }
            else
            {
                var requestConfirmation = new RequestConfirmation(false, "We are sorry server is off ");
                return requestConfirmation;
            }
        }

        public Client getClientInfo()
        {
            return this.clientInfo;
        }
    }
}

