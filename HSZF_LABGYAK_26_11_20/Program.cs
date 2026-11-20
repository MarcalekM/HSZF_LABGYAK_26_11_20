using HSZF_LABGYAK_26_11_20.Logic;
using HSZF_LABGYAK_26_11_20.Repository;

namespace HSZF_LABGYAK_26_11_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebshopLogic logic = new WebshopLogic(new WebshopRepository());
            int count = logic.GetCustomerCount();
            Console.WriteLine($"Customer count: {count}");
            Console.WriteLine(string.Join("\n", logic.GetKoltes()));
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", logic.GetBestProducts()));
        }
    }
}
