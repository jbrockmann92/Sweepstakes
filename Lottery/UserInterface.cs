using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public static class UserInterface
    {
        public static Contestant GetContestantInfo(int numberOfContestants)
        {
            Contestant contestant = new Contestant();
            Console.WriteLine("Please enter the contestant's first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter the contestant's last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter the contestant's email address");
            contestant.email = Console.ReadLine();
            contestant.registrationNumber = numberOfContestants;

            return contestant;
        }

        public static string GetSweepstakesName()
        {
            Console.WriteLine("What would you like the name of this sweepstakes to be?");
            string sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }

        public static ISweepstakesManager StackOrQueue()
        {
            ISweepstakesManager stackOrQueue;
            string stackOrQueueString;
            Console.WriteLine("Would you like to organize your Sweepstakes according to a stack or queue?");
            stackOrQueueString = Console.ReadLine().ToLower();

            if (stackOrQueueString == "stack")
                stackOrQueue = new SweepstakesStackManager();
            else if (stackOrQueueString == "queue")
                stackOrQueue = new SweepstakesQueueManager();
            else
                stackOrQueue = null;

            return stackOrQueue;
        }
    }
}
