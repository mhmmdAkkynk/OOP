using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Taşıt Kredisi
    class TransportCreditManager : ICreditManager
    {
        public void Calculater()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı!");
        }
    }
}
