using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Babek");
            Console.WriteLine("----------myList.Length----------");

            Console.WriteLine(myList.Length);

            //Elave olunan elementin deqiqliyinin yoxlanlasi

            myList.Add("Kenan");
            Console.WriteLine(myList.Length);
            Console.WriteLine("----------myList.Items----------");

            //Elave olunan adlarin siyahsi

            foreach (var names in myList.Items)
            {
                Console.WriteLine(names);
            }

        }
    }
}
