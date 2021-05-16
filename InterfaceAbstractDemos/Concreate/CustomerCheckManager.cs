using InterfaceAbstractDemos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Concreate
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
