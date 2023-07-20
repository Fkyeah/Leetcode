using System.Text;

namespace Problems.Medium
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            StringBuilder result = new();
            var minValue = Math.Pow(-2, 31);
            var maxValue = Math.Pow(2, 31) - 1;

            while (x != 0)
            {
                if (x < 0)
                {
                    result.Append('-');
                    x *= -1;
                }
                    
                result.Append(x % 10);
                x /= 10;
            }

            var isCorrectlyInt32 = Int32.TryParse(result.ToString(), out var resultInt);

            return !isCorrectlyInt32 
                ? 0 
                : resultInt;
        }
    }
}
