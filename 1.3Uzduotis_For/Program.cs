namespace _1._3Uzduotis_For
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int tot = 0;
            for (int i = 1; i <=n ; i++)
            {
                sum += i ;  
            }

            tot = sum / n;
            Console.WriteLine(tot);

        }
    }
}