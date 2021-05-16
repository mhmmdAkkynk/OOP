using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " "+ customer.LastName + " veritabanına kaydedildi!");
        }
    }
}
