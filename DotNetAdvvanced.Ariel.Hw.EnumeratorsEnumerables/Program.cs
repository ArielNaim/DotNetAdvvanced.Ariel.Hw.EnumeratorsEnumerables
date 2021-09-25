using System;
using System.Collections.Generic;

namespace DotNetAdvvanced.Ariel.Hw.EnumeratorsEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> sidra = new List<int>(); 
            List<int> sidraOneTOTen = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                sidraOneTOTen.Add(i);
                int iDubelTen = i * 10;
                sidra.Add(iDubelTen);

                Console.WriteLine(iDubelTen);
            }

            Enumerators number = new Enumerators(3);
            number.SidraExpo();  
        }


    }
}
