namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int broj = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    broj++;
                }
            }

            Console.WriteLine($"Броя е {broj}");
        }
    }
}
