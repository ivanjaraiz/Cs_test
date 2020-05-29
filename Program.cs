using System;

namespace Cs_test
{
    class Program
    {
       public  enum Colors { Red, Green, Blue, Yellow }
        static void Main(string[] args)
        {
            object[] rangeModel = Enum.GetNames(typeof(Colors));
            Console.WriteLine(rangeModel[0]);
            Console.WriteLine(rangeModel[1]);
            Console.WriteLine(rangeModel[2]);
            Console.WriteLine(rangeModel[3]);

        }
    }
}
