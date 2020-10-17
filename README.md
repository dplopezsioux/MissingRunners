# MissingRunners

https://coj.uci.cu/24h/problem.xhtml?pid=4135

Description
You are organizing a marathon with N runners. Every runner is given a distinct number from 1 to N, so they can be easily identified. You record the number of each runner as they cross the finish line. Unfortunately, you notice that only N − 1 runners have finished. Which runner is still out there?
Input specification
The first line of input contains the integer N (1 ≤ N ≤ 2^15). The next line contains N −1 distinct integers in the range from 1 to N, representing the numbers of runners who have crossed the finish line.
Output specification
Output the number of the runner who has not crossed the finish line.
Sample input
5
1 5 2 3
Sample output
4
.

i resolve this in c#
/\*
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

                if ((data[i] +1) != data[i+1])
                {
                    salida = data[i] +1;
                    break;
                }
            }



            Console.WriteLine(salida);

        }
    }

}
\*/
