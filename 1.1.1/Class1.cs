using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskAdditional NewOperation = new TaskAdditional();
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
