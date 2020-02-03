using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            //Example here of dependency injection? I think so, because the constructor takes in an abstraction, and is not dependent on only one class being passed in???
            //This is the factory pattern. If I try to make the decision in this class about queue or stack, I would have to write two different methods or something and it could cause all kinds of problems later
            this.manager = manager;
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            manager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("How many contestants would you like to register?");
            int numberOfContestants = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfContestants; i++)
            {
                sweepstakes.RegisterContestant(UserInterface.GetContestantInfo(i));
            }
        }
    }
}
