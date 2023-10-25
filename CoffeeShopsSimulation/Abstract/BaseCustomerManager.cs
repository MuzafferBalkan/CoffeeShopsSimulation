using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Entities;
using CoffeeShopsSimulation.concrete;

namespace CoffeeShopsSimulation.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db :" +customer.FirstName);
        }
    }
}
