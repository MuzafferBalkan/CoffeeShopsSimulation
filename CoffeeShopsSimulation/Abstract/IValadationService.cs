﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopsSimulation.Entities;
using CoffeeShopsSimulation.concrete;

namespace CoffeeShopsSimulation.Abstract
{
    public interface IValadationService
    {
        bool IfCheckRealPerson(Customer customer);
    }
}
