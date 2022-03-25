using System;

namespace _4reqemlieded
{
    class Program
    {
        static void Main(string[] args)
        {

            string b = "4";

            string a = "44";

            Console.WriteLine("-------------------------");

            Console.WriteLine("Zehmet olmasa 3 reqemli eded daxil edin");

            string num = Console.ReadLine();

            string couplestr = b + num + a;

            Console.WriteLine(couplestr);

            int resultparam = int.Parse(couplestr);

            if (resultparam >=1000)
            {
                Console.WriteLine(resultparam * 0.44);
            }
            else
            {
                Console.WriteLine("Nezere alinmayib");
            }
        }
    }
}
