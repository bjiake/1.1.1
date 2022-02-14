using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Task2 NewOperation = new Task2();
            NewOperation.WriteResult();
            int Value = Convert.ToInt32(Console.ReadLine());
            int Times = Convert.ToInt32(Console.ReadLine());
            int BuffValue = Value;
            for (int Iterator = 1; Iterator < Times; ++Iterator)
            {
                Value *= BuffValue;
            }
            Console.WriteLine(Value);
            
        }
    }
}
