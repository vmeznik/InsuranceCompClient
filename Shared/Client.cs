using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InsuranceComp.Shared
{
    public class Client
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("employer")]
        public string Employer { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("debt")]
        public double Debt { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }


        public Client(string firstName, string lastName, string id,string employer,
            string email, string phone, double debt,string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Employer = employer;
            this.Email = email;
            this.Phone = phone;
            this.Debt = debt;
            this.Address = address;
          
        }

        public Client()
        {

        }


        public override string ToString()
        {
            return "Client{" +
                    "firstName='" + FirstName + '\'' +
                    ", lastName='" + LastName + '\'' +
                    ", id='" + Id + '\'' +
                    ", employer='" + Employer + '\'' +
                    ", email='" + Email + '\'' +
                    ", phone='" + Phone + '\'' +
                    ", debt=" + Debt +
                    ", address='" + Address + '\'' +
                    '}';
        }
    }
}
