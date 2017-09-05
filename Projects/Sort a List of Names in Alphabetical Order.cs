    /*

     * C# Program to Sort a List of Names in Alphabetical Order

     */

    using System;

    using System.Collections.Generic;

    using System.Linq;

    using System.Text;

    namespace ConsoleApplication1

    {

        class Program

        {

            static void Main()

            {

                List<string> names = new List<string>();

                names.Add("Ram");

                names.Add("Rose");

                names.Add("Abs");

                names.Add("Edward");

                names.Add("Sita");

                names.Sort();

                foreach (string s in names) 

                Console.WriteLine(s);

                Console.ReadLine();

            }

        }

    }
