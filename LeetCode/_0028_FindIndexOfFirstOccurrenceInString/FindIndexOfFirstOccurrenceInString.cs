namespace LeetCode._0028_FindIndexOfFirstOccurrenceInString;

//public class Solution
//{
//    public int StrStr(string haystack, string needle)
//    {
//        if (haystack.Length < needle.Length) return -1;

//        for (var i = 0; i < haystack.Length; i++)
//        {
//            if (haystack[i..].StartsWith(needle)) return i;
//        }

//        return -1;
//    }
//}


public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle)) return 0;
        if (haystack.Length < needle.Length) return -1;

        for (var i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
                return i;
        }

        return -1;
    }
}
