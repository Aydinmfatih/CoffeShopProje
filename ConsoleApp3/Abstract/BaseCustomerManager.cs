using AbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Abstract
{
    internal  abstract class BaseCustomerManager : ICustomerService
    {
        public virtual  void Save(Customer customer)
        {
            Console.WriteLine("Saved");
        }
        
    }
}
