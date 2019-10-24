using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_Prime_Numbers
{
    public class Solution
    {
        public List<int> Permute_List = new List<int>();

        public int solution(string numbers)
        {
            int answer = 0;
            PowerSet("", numbers);
            Permute_List = Permute_List.Distinct().ToList();

            foreach (int number in Permute_List)
            {
                if (IsPrime(number))
                    answer++;
            }

            return answer;
        }

        public void PowerSet(string ParentNum, string ChildNum)
        {
            for (int i = 0; i < ChildNum.Length; i++)
            {
                string parent = ParentNum + ChildNum[i];
                string child = ChildNum.Remove(i, 1);
                PowerSet(parent, child);
                Permute_List.Add(Convert.ToInt32(parent));
            }
        }

        public bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number)
                    return false;
            }
            return true;
        }
    }
}
