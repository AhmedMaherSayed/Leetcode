public class Solution {
    public bool IsValid(string s) {
    if (s.Length % 2 != 0)
        return false;

    var stack = new Stack<char>();
    var deletedCharsStack = new Stack<char>();
    foreach (var ch in s)
    {
        if (ch is '[' or '{' or '(')
        {
            stack.Push(ch);
        }
        else if (ch == ']' && stack.Count > 0 && stack.Peek() == '[')
        {
            stack.Pop();
        }
        else if (ch == ')' && stack.Count > 0 && stack.Peek() == '(')
        {
            stack.Pop();
        }
        else if (ch == '}' && stack.Count > 0 && stack.Peek() == '{')
        {
            stack.Pop();
        }
        else
        {
            return false;
        }
    }


    if (stack.Count == 0)
        return true;

    return false;
}
}