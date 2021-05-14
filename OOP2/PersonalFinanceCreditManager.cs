using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bireysel Kredi
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculater()
        {
            Console.WriteLine("Bireysel Kredi ödeme planı hesaplandı!");
        }
    }
}
