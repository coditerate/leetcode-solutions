namespace LeetCode._0014_LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strings)
    {
        if (strings.Length <= 1) return strings[0];

        var shortestLength = strings.Min(i => i.Length);
        if (shortestLength == 0) return string.Empty;

        var returnString = string.Empty;

        for (var i = 0; i < shortestLength; i++)
        {
            var currentLetter = strings[0][i];

            if (strings.All(s => s[i] == currentLetter))
                returnString += currentLetter;
            else
                break;
        }

        return returnString;
    }
}