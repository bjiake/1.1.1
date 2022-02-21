using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TaskAdditional
    {
        public void WriteResult()
        {
            int NumberRemove = 1, CountRemove = 1;
            int Value = Convert.ToInt32(Console.ReadLine());
            if (Value < 10)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                string SwitchValue = Value.ToString();
                char CorrectSwitch = SwitchValue[1];
                SwitchValue = SwitchValue.Remove(NumberRemove, CountRemove);
                SwitchValue = SwitchValue + CorrectSwitch;
                Console.WriteLine(SwitchValue);
            }
        }
    }
}
