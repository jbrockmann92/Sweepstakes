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
