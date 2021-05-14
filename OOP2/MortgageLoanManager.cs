using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Konut Kredisi
    class MortgageLoanManager : ICreditManager
    {
        public void Calculater()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı!");
        }
    }
}
