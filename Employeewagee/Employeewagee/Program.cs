internal class Program
{
    private static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        Random random = new Random();
        int empCheck = random.Next();
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("present");
        }
        else
        {
            Console.WriteLine("absent");
        }
    }
}
