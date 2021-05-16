using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}
