using System;

namespace Biggest_Number
{
    public class Solution
    {
        public string solution(int[] numbers)
        {
            Array.Sort(numbers,
                (a, b) => {
                    return (b.ToString() + a.ToString()).CompareTo(a.ToString() + b.ToString());
                });
            if (numbers[0] == 0) return "0";
            return string.Join("", numbers);
        }
    }
}
