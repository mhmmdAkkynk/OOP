using System;
using System.Collections.Generic;

namespace MyListFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myListSample = new List<string>();
            myListSample.Add("Muhammed");
            myListSample.Add("Akkaynak");
            Console.WriteLine("MyListSample Count : " +myListSample.Count);

            foreach (var value in myListSample)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            Console.WriteLine("*-----------*");
            Console.WriteLine();

            MyList<string> myList = new MyList<string>();
            myList.Add("Muhammed");
            myList.Add("Arda");
            myList.Add("Akkaynak");
            Console.WriteLine("MyList Count : " + myList.Count);

            foreach (var value in myList.GetValue)
            {
                Console.WriteLine(value);
            }
        }
    }
}
