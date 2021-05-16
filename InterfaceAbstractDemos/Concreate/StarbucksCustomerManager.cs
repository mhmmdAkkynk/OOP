using InterfaceAbstractDemos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Concreate
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealCustomer(customer) == true)
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
