using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceComp.Shared
{
    interface IEmpService
    {
        Task<RequestConfirmation> Login(Employee employee);

        Task<RequestConfirmation> Register(Employee employee);

        Task<RequestConfirmation> RegisterClient(Client client);

        Task<Client> ClientsInfo(Client client);

        Task<RequestConfirmation> UpdateClient(Client client);

        Client getClientInfo();
    }
}
