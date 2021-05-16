using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
