namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i < 8; i++) // makes the loop work properly
            {
                Console.WriteLine(diffCurrencies(i));            
            }
        }
        static string diffCurrencies(int x)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
            return currencies[x]; //changes to int x instead of 1 

        }
    }
}
