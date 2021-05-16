using InterfaceAbstractDemos.Abstract;
using MernisServiceReferance;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemos.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
