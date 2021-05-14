using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //İş Sınıfları //Business Classes
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerNumber+ " Müşteri numaralı müşteri eklendi!");
        }
    }
}
