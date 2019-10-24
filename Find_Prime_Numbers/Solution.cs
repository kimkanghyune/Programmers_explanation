using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Prime_Numbers
{
    public class Solution
    {
        public int solution(string numbers)
        {
            int answer = 0;
            List<int> Arr_numbers = new List<int>();

            StringBuilder sb = new StringBuilder();
            Arr_numbers = StringCombination(numbers, sb, 0);
            Collections.

            return answer;
        }
        List<int> StringCombination(string s, StringBuilder sb, int index)
        {
            List<int> Arr_numbers = new List<int>();
            for (int i = index; i < s.Length; i++)
            {
                // 1) 한 문자 추가
                sb.Append(s[i]);

                // 2) 구한 문자조합 출력
                Console.WriteLine(sb.ToString());

                // 3) 나머지 문자들에 대한 조합 구하기
                StringCombination(s, sb, i + 1);

                // 위의 1에서 추가한 문자 삭제 
                sb.Remove(sb.Length - 1, 1);
            }
            return Arr_numbers;
        }
    }
}
