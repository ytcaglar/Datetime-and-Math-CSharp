using System;

namespace datetime_and_math
{
    class Program
    {
        static void Main(string[] args)
        {
            //        --------------------------     DATETIME        ------------------------------
            Console.WriteLine(DateTime.Now); // 14.10.2022 10:53:01
            Console.WriteLine(DateTime.Now.Date); // 14.10.2022 00:00:00
            Console.WriteLine(DateTime.Now.Day); // 14
            Console.WriteLine(DateTime.Now.Month); // 10
            Console.WriteLine(DateTime.Now.Year); // 2022
            Console.WriteLine(DateTime.Now.Hour); // 10
            Console.WriteLine(DateTime.Now.Minute); // 53
            Console.WriteLine(DateTime.Now.Second); // 1
            
            //  ----- TARİH -----
            Console.WriteLine(DateTime.Now.ToLongDateString()); // 14 Ekim 2022 Cuma  
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 14.10.2022

            //  ----- SAAT -----
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 10:55
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 10:55:23


            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi günü = Friday
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı günü = 287

            // ---------------- DATETIME - ADD METHODS -------------------

            Console.WriteLine(DateTime.Now.AddDays(5)); // 19.10.2022 11:17:30
            Console.WriteLine(DateTime.Now.AddMonths(4)); // 14.02.2023 11:17:30
            Console.WriteLine(DateTime.Now.AddYears(10)); // 14.10.2032 11:17:30
            Console.WriteLine(DateTime.Now.AddHours(3)); // 14.10.2022 14:17:30
            Console.WriteLine(DateTime.Now.AddMinutes(2)); // 14.10.2022 11:19:30
            Console.WriteLine(DateTime.Now.AddSeconds(2)); // 14.10.2022 11:17:32

            // ---------------- DATETIME - FORMAT -------------------

            // ---------------- GÜN -------------------

            Console.WriteLine(DateTime.Now.ToString("dd")); // 14
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Cum
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Cuma

            // ---------------- AY -------------------

            Console.WriteLine(DateTime.Now.ToString("MM")); // 10
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Eki
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Ekim

            // ---------------- YIL -------------------

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyy")); // 2022

            //        --------------------------     MATH KÜTÜPHANESİ        ------------------------------

            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(90)); // 0,8939966636005579
            Console.WriteLine(Math.Cos(90)); // -0,4480736161291701
            Console.WriteLine(Math.Tan(45)); // 1,6197751905438615

            Console.WriteLine(Math.Ceiling(22.5)); // 23 - Bir üste yuvarlar
            Console.WriteLine(Math.Round(22.3)); // 22 - En yakın tam sayıya yuvarlar 0,5 ve üstü bir üste, altı ise bir alt tamsayıya yuvarlanır.
            Console.WriteLine(Math.Round(22.7)); // 23
            Console.WriteLine(Math.Floor(22.7)); // 22 - En yakın alt tamsayıya yuvarlar.

            Console.WriteLine(Math.Max(22,7)); // max : 22
            Console.WriteLine(Math.Min(22,7)); // min : 7

            Console.WriteLine(Math.Sqrt(81)); // 9
            Console.WriteLine(Math.Pow(3,4)); // 81

            Console.WriteLine(Math.Log(8)); // 2,0794415416798357 => ln8
            Console.WriteLine(Math.Log10(10)); // 1 => log10
            Console.WriteLine(Math.Exp(10));  // 22026,465794806718 => e^10

        }
    }
}
