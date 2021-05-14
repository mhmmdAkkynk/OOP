using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //Bireysel Müşteri
    class IndividualCustomer : Customer
    {
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
