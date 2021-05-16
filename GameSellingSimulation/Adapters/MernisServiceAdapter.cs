using GameSellingSimulation.Abstract;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameSellingSimulation.Adapters
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
