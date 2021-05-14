using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.NationalityId = "12345678901"; 
            individualCustomer.CustomerNumber = "123456";
            individualCustomer.FirstName = "Muhammed";
            individualCustomer.LastName = "AKKAYNAK";

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CompanyName = "RAAR A.Ş";
            corporateCustomer.CustomerNumber = "654321";
            corporateCustomer.TaxNumber = "987654321";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);

        }
    }
}
