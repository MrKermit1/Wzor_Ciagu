using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ciagi
{
    internal class Program
    {

        static String arytmetczny(List<int> ciag)
        {
            List<int> nowyCiag = new List<int>();
            bool wzorSieZgadza = false;
            //roznica dwoch pierwszych elementow
            int r = ciag[1] - ciag[0];

            for (int i = 0; i < ciag.Count; i++)
            {
                if (i == 0)
                {
                    nowyCiag.Add(ciag[0]);
                }
                if (i == ciag.Count - 1)
                {
                    break;   
                }

                nowyCiag.Add(ciag[i] + r);
            }

            for (int i = 0; i < nowyCiag.Count; i++)
            {
                //Console.WriteLine(nowyCiag[i]);

                if (nowyCiag[i] == ciag[i])
                {
                    wzorSieZgadza = true;
                    
                }
                else
                {
                    wzorSieZgadza = false;
                }

                if (wzorSieZgadza && i == nowyCiag.Count - 1)
                {
                    return "Wzor: " + nowyCiag[0] + " + " + r + "n - " + r;
                }

                if (!wzorSieZgadza && i == nowyCiag.Count - 1)
                {
                    return "Dupa Jaś";
                }
            }

            return String.Empty;
        }

        static String kwadratowy(List<int> ciag)
        {

            return String.Empty;
        }

        static void Main(string[] args)
        {
            //arytmetczny(new List<int> { 11, 22, 33, 44 });
            Console.WriteLine(arytmetczny(new List<int> { 8, 10, 12, 14 }));
            Console.ReadKey();
        }
    }
}
