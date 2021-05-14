using System;
using System.Collections.Generic;

namespace MyDictionaryFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionarySample = new Dictionary<string, string>();
            myDictionarySample.Add("Name" , "Muhammed");
            myDictionarySample.Add("Surname" , "AKKAYNAK");
            myDictionarySample.Add("Age" , "24");
            Console.WriteLine("MyDictionarySample Count : " + myDictionarySample.Count);

            foreach (var key in myDictionarySample)
            {
                Console.WriteLine("Keys : "+ key.Key);
            }

            foreach (var value in myDictionarySample)
            {
                Console.WriteLine("Values : " + value.Value);
            }
            Console.WriteLine();
            Console.WriteLine("*-----------*");
            Console.WriteLine();


            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Name", "Muhammed");
            myDictionary.Add("UserName", "AKKAYNAK");
            myDictionary.Add("Age", "24");

            Console.WriteLine("myDictionary Count : "+ myDictionary.GetValueCount);

            foreach (var key in myDictionary.GetKey)
            {
                Console.WriteLine("Keys : "+ key);
            }

            foreach (var value in myDictionary.GetValue)
            {
                Console.WriteLine("Values : "+ value);
            }
        }
    }
}
