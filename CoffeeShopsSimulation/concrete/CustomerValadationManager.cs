using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Abstract;
using CoffeeShopsSimulation.Entities;

namespace CoffeeShopsSimulation.concrete
{
    class CustomerValadationManager : IValadationService
    {
        public bool IfCheckRealPerson(Customer customer)//simülasyon mernis
        {
            return true;
        }
    }
}
