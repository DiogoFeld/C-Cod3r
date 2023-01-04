using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Api
{
    internal class TimeSpanEx
    {
        public void Main()
        {
            TimeSpan time = new TimeSpan(days:10, hours:40, minutes:20, seconds:4);
            Console.WriteLine(time.ToString());
            Console.WriteLine(time.Minutes);
            Console.WriteLine(time.TotalMinutes);//soma do total em minutos

            Console.WriteLine(time.Add(TimeSpan.FromMinutes(2)));//soma 2 dos minutos ao total
            Console.WriteLine(time.Subtract(TimeSpan.FromMinutes(4)));//subtrai 4 dos minutos ao total

            Console.WriteLine($"To String {time.ToString("g")}");
            Console.WriteLine($"To String {time.ToString("G")}");
            Console.WriteLine($"To String {time.ToString("c")}");            


            //parsing
            Console.WriteLine($"Parsing : {TimeSpan.Parse("04:03:20").TotalHours}");            

        }



    }
}
