namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhập n: ");
            n = int.Parse(Console.ReadLine());

            int k;
            Console.WriteLine("Nhập k: ");
            k = int.Parse(Console.ReadLine());

            if (n <= 0 || k > n || n == k)
            {
                Console.WriteLine("No result");
            }
            else
            {
                for (int i = k; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}