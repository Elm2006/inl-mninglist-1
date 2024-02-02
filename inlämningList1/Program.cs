using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace inlämingList1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();
            string svar = "";
            do
            {
                Console.WriteLine("Skriv in ett namn");
                svar = Console.ReadLine();
                namn.Add(svar);
            } while (svar != "");
            namn.Sort();
            namn.Reverse();
            foreach(string n in namn)
            {
                Console.WriteLine(n);
            }
        }
    }
}