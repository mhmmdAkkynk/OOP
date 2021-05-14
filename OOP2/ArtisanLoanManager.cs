using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Esnaf Kredisi
    class ArtisanLoanManager : ICreditManager
    {
        public void Calculater()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı!");
        }
    }
}
