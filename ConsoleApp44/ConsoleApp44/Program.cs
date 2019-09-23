using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете ЕГН:");
            string pol;
            double num;
            string egn = Console.ReadLine();
            
            if (!double.TryParse(egn, out num))
            {
                Console.WriteLine("ЕГН-то трябва да е само числа");
            }
            else if (egn.Length != 10)
            {
                Console.WriteLine("Невалидно егн"); 
            }
            else
            {
                int year = int.Parse(egn.Substring(0, 2));
                int month = int.Parse(egn.Substring(2, 2));
                int day = int.Parse(egn.Substring(4, 2));
                int sex = int.Parse(egn.Substring(6, 2));
                if (month < 20)
                {
                    year += 1900;
                }
                else if (month >= 40)
                {
                    year += 2000;
                    month -= 40;
                }
                if (sex % 2 == 0)
                {
                    pol = "Жена";
                }
                else
                {
                    pol = "Мъж";
                }


                Console.WriteLine("Датата на раждане на човека е: "  + (day + "." + month + "." + year));
                var data = new DateTime(year, month, day);
                DateTime datab = Convert.ToDateTime(data);
                DateTime PresentYear = DateTime.Now;
                TimeSpan ts = PresentYear - datab;
                DateTime Age = DateTime.MinValue.AddDays(ts.Days);
                Console.WriteLine();
                Console.WriteLine("Благодаря Ви!");
                Console.Write("Моля изчакайте!");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(string.Format("Човекът е на {0} Години {1} месеца {2} дни! \n Пол: {3}!", Age.Year - 1, Age.Month - 1, Age.Day - 1, pol));
                
            } 
        }
    }
    
}
