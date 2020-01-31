using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public static class UserInterface
    {
        public static Contestant GetContestantInfo()
        {
            Contestant contestant = new Contestant();
            Random random = new Random();
            Console.WriteLine("Please enter the contestant's first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter the contestant's last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter the contestant's email address");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = random.Next(100, 10000);
                //Want to add one to it each time. For loop?

            return contestant;

            //More needed on the interface? Probably. Anytime I want to interact with the user
        }

        public static string GetSweepstakesName()
        {
            Console.WriteLine("What would you like the name of this sweepstakes to be?");
            string sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }
    }
}
