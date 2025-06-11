namespace LeetCode._0009_PalindromeNumber;

//public class Solution
//{
//    public bool IsPalindrome(int x)
//    {
//        var xDigits = x.ToString().ToCharArray();

//        var leftIndex = 0;
//        var rightIndex = xDigits.Length - 1;

//        while (leftIndex <= rightIndex)
//        {
//            if (xDigits[leftIndex] == xDigits[rightIndex])
//            {
//                leftIndex++;
//                rightIndex--;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}


public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers and numbers ending with 0 (except 0 itself) can't be palindromes
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        var reversed = 0;

        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        // For even-length numbers: x == reversed
        // For odd-length numbers: x == reversed / 10 (middle digit is ignored)
        return x == reversed || x == reversed / 10;
    }
}
