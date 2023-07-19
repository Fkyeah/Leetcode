namespace Problems.Easy
{
    public class PascalTriangleIISolution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var numRows = rowIndex + 1;
            int[] prevArray = new int[1] { 1 };
            for (int i = 1; i < numRows; i++)
            {
                var currArray = new int[i + 1];

                currArray[0] = 1;
                currArray[currArray.Length - 1] = 1;

                for (int j = 1; j <= (currArray.Length - 1) / 2; j++)
                {
                    currArray[j] = prevArray[j - 1] + prevArray[j];
                    currArray[currArray.Length - 1 - j] = prevArray[j - 1] + prevArray[j];
                }

                prevArray = currArray;
            }

            return prevArray.ToList();
        }
    }
}
