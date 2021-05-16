using InterfaceAbstractDemos.Abstract;
using InterfaceAbstractDemos.Adapter;
using InterfaceAbstractDemos.Concreate;
using System;

namespace InterfaceAbstractDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Muhammed";
            customer.LastName = "Akkaynak";
            customer.DateOfBirth = new DateTime(1997, 5, 24);
            customer.NationalityId = "this is your nationality number";

            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(customer);
        }
    }
}
