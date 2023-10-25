using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Abstract;
using CoffeeShopsSimulation.Entities;
using CoffeeShopsSimulation.Adapters;


namespace CoffeeShopsSimulation.concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IValadationService _ıValadationService;
        public StarbucksCustomerManager(IValadationService valadationService)
        {
            _ıValadationService = valadationService;
        }
        public override void Save(Customer customer)
        {
            if (_ıValadationService.IfCheckRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }
    }
}
