using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_th_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            foreach (int i in solution.solution(
                new int[] { 1, 5, 2, 6, 3, 7, 4 },
                new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } }
                ))
            {
                Console.Write(i);
            }
        }
    }
}
