using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvvanced.Ariel.Hw.EnumeratorsEnumerables
{
    public class Enumerators
    {
        public int numbersForPractise { get; set; }
        
        public Enumerators (int number)
        {
            numbersForPractise = number;
        }
        List<int> oneToTen = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int SidraExpo()
        {
            int resolt = 1;
            foreach (var item in oneToTen)
            {
              resolt = (int)Math.Pow(numbersForPractise, item);
                Console.WriteLine(resolt);
            }
            return resolt;
        }

    }
}
