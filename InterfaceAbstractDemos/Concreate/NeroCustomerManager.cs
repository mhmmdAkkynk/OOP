using InterfaceAbstractDemos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Concreate
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
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
