namespace LeetCode._0013_RomanToInteger;

//public class Solution
//{
//    public int RomanToInt(string s)
//    {
//        var returnValue = 0;

//        var romanNumerals = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

//        if (string.IsNullOrEmpty(s)) return 0;

//        if (s.Length == 1) return romanNumerals.GetValueOrDefault(s[0], 0);

//        for (var i = 0; i < s.Length; i++)
//        {
//            var currentChar = s[i];
//            var nextChar = i == s.Length - 1 ? 'Z' : s[i + 1];

//            switch (currentChar)
//            {
//                case 'I':
//                    if (new[] { 'V', 'X' }.Contains(nextChar))
//                    {
//                        returnValue += romanNumerals[nextChar] - romanNumerals[currentChar];
//                        i++;
//                    }
//                    else
//                        returnValue += romanNumerals[currentChar];
//                    break;
//                case 'V':
//                    returnValue += romanNumerals[currentChar];
//                    break;
//                case 'X':
//                    if (new[] { 'L', 'C' }.Contains(nextChar))
//                    {
//                        returnValue += romanNumerals[nextChar] - romanNumerals[currentChar];
//                        i++;
//                    }
//                    else
//                        returnValue += romanNumerals[currentChar];
//                    break;
//                case 'L':
//                    returnValue += romanNumerals[currentChar];
//                    break;
//                case 'C':
//                    if (new[] { 'D', 'M' }.Contains(nextChar))
//                    {
//                        returnValue += romanNumerals[nextChar] - romanNumerals[currentChar];
//                        i++;
//                    }
//                    else
//                        returnValue += romanNumerals[currentChar];
//                    break;
//                case 'D':
//                    returnValue += romanNumerals[currentChar];
//                    break;
//                case 'M':
//                    returnValue += romanNumerals[currentChar];
//                    break;
//                default:
//                    returnValue = 0;
//                    break;
//            }
//        }

//        return returnValue;
//    }
//}

public class Solution
{
    public int RomanToInt(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        var romanNumerals = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

        var total = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var currentValue = romanNumerals[s[i]];
            var nextValue = (i + 1 < s.Length) ? romanNumerals[s[i + 1]] : 0;

            if (currentValue < nextValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }
        }

        return total;
    }
}
