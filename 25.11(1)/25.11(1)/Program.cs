using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
   //Метод ParseExact
   /*string date = "17022004";
   DateTime dt = DateTime.ParseExact(date, "ddMMyyyy", CultureInfo.InvariantCulture);
   Console.WriteLine(dt);*/

   //Метод Parse
   /*string[] strDate = new string[]
   {
       "09/19/2022 25:22:17",
       "09/19/2022",
       "9/2022",
       "9/19",
       "25:22:17",
       "6 PM",
       "2022-09-19T07:22:19.0000000Z",
       "2022-09-19T07:22:19.0000000-07:00",
       "Thu, 18 Aug 2022 08:22:18 GMT",
       "08/18/2022 07:22:16 -5:00"
   };
   foreach (string str in strDate)
   {
       DateTime dt = DateTime.Parse(str, CultureInfo.GetCultureInfo("en-US"));
       Console.WriteLine($"{dt}");
   }*/

   //Метод TryParse и TryParseExact
   string[] strDate = new string[]
   {
                "09/19/2022 25:22:17",
                "09/19/2022",
                "9/2022",
                "9/19",
                "25:22:17",
                "6 PM",
                "2022-09-19T07:22:19.0000000Z",
                "2022-09-19T07:22:19.0000000-07:00",
                "Thu, 18 Aug 2022 08:22:18 GMT",
                "08/18/2022 07:22:16 -5:00"
   };

   foreach (string str in strDate)
   {
    DateTime dt;
    if (DateTime.TryParse(str, out dt))
    {
     Console.WriteLine($"{dt}");
    }
    else
     Console.WriteLine("Error");
    Console.ReadLine();
   }
  }
    }
}
