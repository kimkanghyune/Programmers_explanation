using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Prime_Numbers
{
    public class Solution
    {
        List<int> Permute_List = new List<int>();
        private void permute(string str, int l, int r)
        {
            if (l == r)
                Permute_List.Add(Convert.ToInt32(str));
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        public int solution(string numbers)
        {
            int answer = 0;
            permute(numbers, 0, numbers.Length - 1);

            for (int i = 2; i < Permute_List.Max(); i++)
            {
                Permute_List.RemoveAll(
                    delegate (int x)
                {
                    return x > i && x % i == 0; 
                }
                );
            }

            Permute_List = Permute_List.Distinct().ToList();

            Permute_List.ForEach(
                delegate (int x) 
                { 
                    Console.Write("{0} ", x); 
                }
                );

            return answer;
        }
    }
}
