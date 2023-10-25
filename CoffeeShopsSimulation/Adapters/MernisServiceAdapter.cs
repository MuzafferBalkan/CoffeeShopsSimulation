using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Abstract;
using CoffeeShopsSimulation.Entities;

namespace CoffeeShopsSimulation.Adapters
{
    public class MernisServiceAdapter : IValadationService
    {
        public bool IfCheckRealPerson(Customer customer) //Gerçek mernis
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.IdentyNumber), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
