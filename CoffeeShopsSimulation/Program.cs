using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Abstract;
using CoffeeShopsSimulation.concrete;
using CoffeeShopsSimulation.Entities;
using CoffeeShopsSimulation.Adapters;


namespace CoffeeShopsSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { Id = 1, FirstName = "Muzaffer İlkay", LastName = "Balkan", DateOfBirth = new DateTime(2004,12,22), IdentyNumber = "12345678910" }); // yanlış Identy number
            Console.ReadLine();

        }
    }
}
