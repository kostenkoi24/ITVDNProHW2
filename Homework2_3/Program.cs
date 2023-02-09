using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCollection1();
            PrintCollection2();
            Console.ReadKey();
        }


        static void PrintCollection1()
        {
            
            var myCollection = new Hashtable();

            myCollection["b1"] = 999;
            myCollection["b2"] = 666;
            myCollection["b3"] = -10;


            foreach (DictionaryEntry name in myCollection)
            {
                Console.WriteLine("{0}, {1}", name.Value, name.Key);
            }
            Console.WriteLine(new string('-', 20));
        }


        static void PrintCollection2()
        {

            var myCollection = new Dictionary<string, int>();
            myCollection["b1"] = 888;
            myCollection["b2"] = 999;
 
            foreach (KeyValuePair<string, int> i in myCollection)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));
           
        }


    }
}
