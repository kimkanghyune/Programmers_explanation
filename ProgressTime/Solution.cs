using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTime
{
    public class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            List<int> Restnum = new List<int>();
            List<int> Count = new List<int>();

            for (int i = 0; i < progresses.Length; i++)
            {
                Restnum.Add(
                    Convert.ToInt32(
                        Math.Ceiling( 
                            Convert.ToDouble(100 - progresses[i]) / Convert.ToDouble(speeds[i]))
                        ) 
                    );
            }

            for(int i = 0; i < Restnum.Count - 1; i++)
            {
                if(Restnum[i] > Restnum[i + 1])
                {
                    Restnum[i + 1] = Restnum[i];
                }
            }

            Count = Restnum.Distinct().ToList();

            int tmpcount = 0;
            for (int i = 0; i < Count.Count; i++)
            {
                for (int j = 0; j < Restnum.Count; j++)
                {
                    if(Count[i] == Restnum[j])
                    {
                        tmpcount++;
                    }
                }
                answer.Add(tmpcount);
            }

            return answer.ToArray();
        }
    }
}