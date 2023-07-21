using System.Text;

namespace Problems.Easy
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            var result = a.Length > b.Length
                ? Sum(a, b.PadLeft(a.Length, '0'))
                : Sum(b, a.PadLeft(b.Length, '0'));

            return result;
        }

        public string Sum(string a, string b)
        {
            int remainder = 0;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < b.Length; i++)
            {
                var charA = a[a.Length - 1 - i];
                var charB = b[b.Length - 1 - i];

                var sum = charA + charB + remainder;

                if (sum == 96) // 0 + 0
                {
                    stack.Push('0');
                    continue;
                }

                if (sum == 97) // 1 + 0
                {
                    stack.Push('1');
                    remainder = 0;
                    continue;
                }

                if (sum == 98) // 1 + 1
                {
                    stack.Push('0');
                    remainder = 1;
                    continue;
                }

                if (sum == 99) // 1 + 1 + 1
                {
                    stack.Push('1');
                    remainder = 1;
                    continue;
                }
            }

            if (remainder > 0)
            {
                stack.Push('1');
            }

            StringBuilder stringBuilder = new StringBuilder();
            var resultLength = stack.Count;

            for (int i = 0; i < resultLength; i++)
            {
                stringBuilder.Append(stack.Pop());
            }

            return stringBuilder.ToString();
        }
    }
}
