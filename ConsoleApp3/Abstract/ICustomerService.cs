﻿using AbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Abstract
{
    internal  interface ICustomerService
    {
        void  Save(Customer customer);
        
    }
}
