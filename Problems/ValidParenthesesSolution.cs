namespace Problems
{
    public class ValidParenthesesSolution
    {
        public string s = "()";
        public string s2 = "()[]{}";
        public string s3 = "(]";
        public string s4 = "{[]}";

        /// Runtime - 77 ms, Memory - 37,78 Mb
        public bool IsValid(string s)
        {
            Stack<char> stk = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stk.Push(s[i]);
                }
                else
                {
                    if (stk.Count() == 0)
                    {
                        return false;
                    }
                    else if (!IsMatch(stk.Peek(), s[i]))
                    {
                        return false;
                    }
                    else
                    {
                        stk.Pop();
                    }
                }
            }

            return stk.Count() == 0;

            bool IsMatch(char a, char b)
            {
                return (
                    (a == '(' && b == ')')
                    || (a == '{' && b == '}')
                    || (a == '[' && b == ']')
                    );
            }
        }
    }
}
