using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of class
            Profile sam = new Profile("Sam Drakkila", 30);

            //call the SetHobbies() method and add string array of hobbies
            /* sam
                .SetHobbies(new string[] {
                    "traveling",
                    "cooking",
                    "listen to music"
                }); */
            //call the ViewProfile method
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
