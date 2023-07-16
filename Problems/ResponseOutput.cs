namespace Problems
{
    public class ResponseOutput
    {
        public static void Write<T>(IEnumerable<T> response)
        {
            Console.WriteLine($"[ {string.Join(", ", response)} ]");
        }

        public static void Write<T>(T response)
        {
            Console.WriteLine($"{response}");
        }
    }
}
