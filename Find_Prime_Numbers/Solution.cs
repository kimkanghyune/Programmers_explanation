using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 문제 설명
 * 한자리 숫자가 적힌 종이 조각이 흩어져있습니다. 흩어진 종이 조각을 붙여 소수를 몇 개 만들 수 있는지 알아내려 합니다.
 * 
 * 각 종이 조각에 적힌 숫자가 적힌 문자열 numbers가 주어졌을 때, 종이 조각으로 만들 수 있는 소수가 몇 개인지 return 하도록 solution 함수를 완성해주세요.
 * 
 * 제한사항
 * numbers는 길이 1 이상 7 이하인 문자열입니다.
 * numbers는 0~9까지 숫자만으로 이루어져 있습니다.
 * 013은 0, 1, 3 숫자가 적힌 종이 조각이 흩어져있다는 의미입니다.
 * 입출력 예
 * numbers	return
 * 17	3
 * 011	2
 * 입출력 예 설명
 * 예제 #1
 * [1, 7]으로는 소수 [7, 17, 71]를 만들 수 있습니다.
 * 
 * 예제 #2
 * [0, 1, 1]으로는 소수 [11, 101]를 만들 수 있습니다.
 * 
 * 11과 011은 같은 숫자로 취급합니다.
 * 출처
 */

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
