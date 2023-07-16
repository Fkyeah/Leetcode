namespace Problems
{
    public class ResponseOutput
    {
        public static void WriteIEnumerable<T>(IEnumerable<T> response)
        {
            Console.WriteLine($"[ {string.Join(", ", response)} ]");
        }
    }
}
