using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodes
{
    internal class project
    {

    }
    public class TwoSums
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] a = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                
                for (int j = i+1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target)
                    { a[0] = i; a[1] = j; }
                    /*Console.WriteLine($"[{i},{j}]");*/
                }
            }
            return a;
        }
    }
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int right = 0, left = x;
            while (x > 0)
            {
                right *= 10;
                right += x % 10;
                x /= 10;
            }
            if (left == right) return true; else return false;
        }
    }
    public class RomanToInts
    {
        public static int RomanToInt(string s)
        {
            int res = 0;
            for (int i = s.Length-1; i >= 0 ; i--)
            {
                if (i == 0) { res += Res(s[i]); break; }
                else if (Res(s[i]) <= Res(s[i - 1])) res += Res(s[i]);
                else if (Res(s[i]) > Res(s[i - 1])) { res += (Res(s[i]) - Res(s[i-1])); i--; }
                
            }
            return res;
        }
        public static int Res(char s)
        {
            switch (s)
            {
                case 'I': return 1; break;
                case 'V': return 5; break;
                case 'X': return 10; break;
                case 'L': return 50; break;
                case 'C': return 100; break;
                case 'D': return 500; break;
                case 'M': return 1000; break;
            }
            return 0;
        }
        
    }
}
