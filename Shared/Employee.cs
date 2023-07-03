using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InsuranceComp.Shared
{
    public class Employee
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }


        public Employee(string firstName, string lastName, string email, string password, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Id = id;
        }

        public Employee()
        {

        }

        public override string ToString()
        {
            return "Employee{" +
                    "firstName='" + FirstName + '\'' +
                    ", lastName='" + LastName + '\'' +
                    ", email='" + Email + '\'' +
                    ", password='" + Password + '\'' +
                    ", id='" + Id + '\'' +
                    '}';
        }
    }
}
