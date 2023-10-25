using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Abstract;
using CoffeeShopsSimulation.Entities;

namespace CoffeeShopsSimulation.concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
      /*  IValadationService valadationService;                                         -Eğer istersek nero içinde mernis doğrulamasını aktif
public NeroCustomerManager(IValadationService valadationService)                        hale getirebiliriz 
        {
            this.valadationService = valadationService;
        }

        public override void Save(Customer customer)
        {
            if (valadationService.IfCheckRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
        }*/
    }
}
