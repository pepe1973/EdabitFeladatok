﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a sztringet: ");
            string bemeno = Console.ReadLine();
            Console.Write("Kérem az ismétlés számát: ");
            int hanyszor = Int32.Parse(Console.ReadLine());
            Szoveg szoveg = new Szoveg(bemeno);
            Console.WriteLine($"Az ismételt sztring: {Ismetel(bemeno, hanyszor)}");
            Console.WriteLine($"Az ismételt sztring: {szoveg.Ismetel(hanyszor)}");

            Console.ReadKey(true);
        }

        static string Ismetel(string bemeno, int hanyszor)
        {
            string kimeno = "";

            if (bemeno.Length == 0)
            {
                return kimeno = "Üres sztringgel nem tudok dolgozni!";
            }
            else
            {
                for (int i = 0; i < bemeno.Length; i++)
                {
                    for (int j = 0; j < hanyszor; j++)
                    {
                        kimeno = String.Concat(kimeno, bemeno[i]);
                    }
                }

                return kimeno;
            }
        }
    }
}
