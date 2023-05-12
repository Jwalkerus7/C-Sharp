using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = false;
            string wear = "Wear sunglasses!";
            string dontWear = "You don't need to wear sunglasses.";

            bool atBeach = true;
            string sunblock = "Sunblock is a good idea.";
            string noSunblock = "Sunblock isn't needed.";

            bool goAnyway = true;
            string going = "Awesome! Glad you don't mind clouds!";
            string nextTime = "No worries! Hopefully next time we will have some fun!";

            if(isSunny)
            {
                Console.WriteLine(wear);
            }
            else
            {
                Console.WriteLine(dontWear);
            }


            if(atBeach)
            {
                Console.WriteLine(sunblock);
            }
            else
            {
                Console.WriteLine(noSunblock);
            }


            if(goAnyway)
            {
                Console.WriteLine(going);
            }
            else
            {
                Console.WriteLine(nextTime);
            }
        
        }
    }
}