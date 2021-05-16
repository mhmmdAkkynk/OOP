using GameSellingSimulation.Abstract;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Concrete
{
    class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealCustomer(customer) == true)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " your account has been saved!");
            }
            else
            {
                Console.WriteLine("Your account not has been saved!");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " your account has been updated!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " your account has been deleted!");
        }
    }
}
