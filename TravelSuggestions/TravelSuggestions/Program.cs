using System;

namespace TravelSuggestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1, answer2;

            Console.WriteLine("Hello user, what are you in the mood for?");


            Console.WriteLine("Here are your options: 1) Chill Times 2) Action 3) Danger 4) Good Food");
            answer1 = Console.ReadLine();

            Console.WriteLine("How many people are you bringing with you?");
            answer2 = Console.ReadLine();

            if (answer1 == "1")

                Console.WriteLine("Okay, if you're in the mood for chill times then you should go Hiking");
            else if (answer1 == "2")
                Console.WriteLine("Okay, if you're in the mood for adventure then you should go Stock Car Racing");

            else if (answer1 == "3")
                Console.WriteLine("Okay, if you're in the mood for danger then you should go Skydiving");

            else if (answer1 == "4")
                Console.WriteLine("Okay, if you're in the mood for good food then you should go to Taco Bell");

            int i = int.Parse(answer2);
            if (i <= 0)
            {
                Console.WriteLine("and you should use running shoes to get there.");
            }
           if (i >= 0 && i <= 4)
            {
                Console.WriteLine("and you should travel in a sedan.");
            }
           if (i >= 5 && i <= 10)
            {
                Console.WriteLine("and you should travel in a volkswagen bus.");
            }
           if (i >= 11)
            {
                Console.WriteLine("and you should take an airplane.");
            }

            Console.WriteLine("Goodbye.");


        }

       

       
    }


}


