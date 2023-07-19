namespace Problems.Easy
{
    public class PascalTriangleSolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            
            for (int i = 1; i <= numRows; i++)
            {
                var arr = new int[i];
                arr[0] = 1;
                arr[arr.Length - 1] = 1;

                

                if (i > 2)
                {
                    for (int j = 1; j <= (arr.Length - 1) / 2; j++)
                    {
                        var prevArr = result.LastOrDefault().ToArray();

                        arr[j] = prevArr[j - 1] + prevArr[j];
                        arr[arr.Length - 1 - j] = prevArr[j - 1] + prevArr[j];
                    }
                }

                result.Add(arr.ToList());
            }

            return result;
        }
    }
}
