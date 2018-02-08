using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Assignment.PMDictionary
{
    class PMDictionary
    {
        public static void Answer()
        {
            Dictionary<int, PrimeMinister> pm = new Dictionary<int, PrimeMinister>();

            pm.Add(1998, new PrimeMinister("Atal Bihari Vajpayee"));
            pm.Add(2014, new PrimeMinister("Narendra Modi"));
            pm.Add(2004, new PrimeMinister("Manmohan Singh"));

            Console.WriteLine("\n\nProblem 3: Prime Minister Dictionary");
            
            Console.WriteLine("Prime minister of 2004: " + pm[2004].name);

            pm.Add(2018, new PrimeMinister("Narendra Modi"));
            Console.WriteLine("\nCurrent PM details are added in the dictionary.");

            ReadOnlyDictionary<int, PrimeMinister> pmReadOnly = new ReadOnlyDictionary<int,PrimeMinister>(pm);

            Console.WriteLine("\nValues in ReadOnly Dictionary:");
            foreach (var p in pmReadOnly)
            {
                Console.WriteLine(p.Key + " " + p.Value.name);
            }

            Console.WriteLine("\nSorted Dictionary By year:");
            pm = pm.OrderBy(y => y.Key).ToDictionary(t => t.Key, t => t.Value);
            foreach (var p in pm)
            {
                Console.WriteLine(p.Key + " " + p.Value.name);
            }


        }
    }
}
