﻿//Enrick De Munter nr3 5ITN 29/11/19
/* OPGAVE
 * ======
 * 1)TVV V5
 * 2)TVV V getallen ingegeven door user
 * 3)2x TVV V "                     "
 * 4) OPGAVE ZELF
 * 
 * 
 *ANALYSE
 * VRAAG GEEF DE TAFELS VAN 5
 * 
 * PROCESSING
 * BEREKEN ALLE TAFELS VAN 5
 * 
 * TOON ALLE TAFELS VAN 5
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drilkaarttafels
{
    class Program
    {
        static void Main(string[] args)
        {
            int tafels;
            
            int somTafels,somTafels2;
            Console.WriteLine("geef het getal waar u de tafels van wilt?: ");
            tafels = int.Parse( Console.ReadLine());

            Console.WriteLine($"de tafels van {tafels} zijn:");
            
            for (int getMaal = 1; getMaal < 12; getMaal++)
            {
                somTafels = tafels * getMaal ;
                Console.WriteLine($"{tafels}*{getMaal}={somTafels}");
            }

            tafels++;

            for (int getMaal2 = 0; getMaal2 < 12; getMaal2++)
            {
                somTafels2 = tafels * getMaal2;
                Console.WriteLine($"{tafels}*{getMaal2}={somTafels2}");
            }

            //wachten.....
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
