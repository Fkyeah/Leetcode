namespace Problems.Easy
{
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (GetIntFromRoman(s[i]) < GetIntFromRoman(s[i + 1]))
                {
                    result -= GetIntFromRoman(s[i]);
                }
                else
                {
                    result += GetIntFromRoman(s[i]);
                }
            }

            return result + GetIntFromRoman(s[s.Length - 1]);
        }

        private int GetIntFromRoman(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }
    }
}
