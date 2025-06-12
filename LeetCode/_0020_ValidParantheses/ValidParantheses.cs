namespace LeetCode._0020_ValidParantheses;

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        var stack = new Stack<char>();

//        foreach (var p in s)
//        {
//            if (new[] { '(', '{', '[' }.Contains(p))
//                stack.Push(p);

//            if (new[] { ')', '}', ']' }.Contains(p))
//            {
//                if (stack.Count == 0) return false;

//                var lastParanthesis = stack.Pop();

//                if (p == ')' && lastParanthesis != '(')
//                    return false;

//                if (p == '}' && lastParanthesis != '{')
//                    return false;

//                if (p == ']' && lastParanthesis != '[')
//                    return false;

//            }
//        }

//        return stack.Count <= 0;
//    }
//}

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var matchingBrackets = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };

        foreach (var ch in s)
        {
            if (matchingBrackets.ContainsValue(ch))
                stack.Push(ch);
            else if (matchingBrackets.TryGetValue(ch, out var bracket))
            {
                if (stack.Count == 0 || stack.Pop() != bracket) return false;
            }
        }

        return stack.Count == 0;
    }
}
