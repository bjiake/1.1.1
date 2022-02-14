using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._1
{
    class Task2
    {
        public void WriteResult()
        {
            int NumberRemove = 1, CountRemove = 1;
            int value = Convert.ToInt32(Console.ReadLine());
            if (value < 10)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                string SwitchValue = value.ToString();
                char CorrectSwitch = SwitchValue[1];
                SwitchValue = SwitchValue.Remove(NumberRemove, CountRemove);
                SwitchValue = SwitchValue + CorrectSwitch;
                Console.WriteLine(SwitchValue);
            }
        }
    }
}
