using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int values = int.Parse(Console.ReadLine());

            string[] CadenasValues = Console.ReadLine().Split(' ');

            List<int> data = (from string item in CadenasValues
                              select int.Parse(item)).ToList();

            data.Sort();

            int salida = 0;

            for (int i = 0; i < data.Count; i++)
            {

                if ((data[i] + 1) != data[i + 1])
                {
                    salida = data[i] + 1;
                    break;
                }
            }
            Console.WriteLine(salida);

        }
    }
}
