using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Api
{
    internal class DatetimeEx
    {
        public void Main()
        {
            DateTime date = new DateTime(2023, 1, 4);

            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);

            Console.WriteLine("------");

            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow.Year);
            Console.WriteLine(dateNow.Month);
            Console.WriteLine(dateNow.Day);

            DateTime dateAmanha = dateNow.AddDays(1);
            Console.WriteLine(dateAmanha.Year);
            Console.WriteLine(dateAmanha.Month);
            Console.WriteLine(dateAmanha.Day);

            Console.WriteLine("descritivo");
            Console.WriteLine(dateNow.ToString("dd"));
            Console.WriteLine(dateNow.ToString("d"));
            Console.WriteLine(dateNow.ToString("D"));
            Console.WriteLine(dateNow.ToString("g"));
            Console.WriteLine(dateNow.ToString("G"));
        }


    }
}
