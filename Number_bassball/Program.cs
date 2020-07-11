using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Number_bassball
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(new int[,] { 
                { 123, 1, 1 }, 
                { 356, 1, 0 }, 
                { 327, 2, 0 }, 
                { 489, 0, 1 }
            });

        }
    }
}
