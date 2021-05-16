using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}
