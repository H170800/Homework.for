namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập n: ");

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            if (n < 0 || n >= 100)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}