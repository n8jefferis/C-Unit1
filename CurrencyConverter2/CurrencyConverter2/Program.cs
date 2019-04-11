using System;
using System.Globalization;
using System.Text;

namespace CurrencyConverter2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Enter a number:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter another number:");
            string second = Console.ReadLine();

            Console.WriteLine("Enter one last number:");
            string third = Console.ReadLine();

   
            Single f = Convert.ToSingle(first);
            Single s = Convert.ToSingle(second);
            Single t = Convert.ToSingle(third);


          





            float smallest;
            if (f <= s && f <= t)
            {
                smallest = f;
            }
            else if (s <= t && s <= f)
            {
                smallest = s;
            }
            else
            {
                smallest = t;
            }

            float largest;
            if (f >= s && f >= t)
            {
                largest = f;
            }
            else if (s >= t && s >= f)
            {
                largest = s;
            }
            else
            {
                largest = t;
            }

            Single total = (f + s + t);
            Single avg = (total / 3);


            //For Japan

            Console.WriteLine("Japanese " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            //For Sweeden

            Console.WriteLine("Sweedish " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));


            // For Thailand

            Console.WriteLine("Thai: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));
           


            //For US

            Console.WriteLine("US: " + total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); 
         





            Console.WriteLine("The largest ammount is " + largest);
            Console.WriteLine("The smallest ammount is " + smallest);
            Console.WriteLine("The average of all three dollar ammounts is " + avg);
            //Console.WriteLine("Total value is US: $" + total );
            //Console.WriteLine("Total value is Sweedish: " + total);
          //  Console.WriteLine("Total value is Japanese: " + total);
           // Console.WriteLine("Total value is Thai: ฿" + total);
        }



    }
}
