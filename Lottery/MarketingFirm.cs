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
            int numberOfContestants = UserInterface.GetContestantNumber();
            for (int i = 0; i < numberOfContestants; i++)
            {
                Console.WriteLine($"Enter contestant {i + 1}'s info");
                sweepstakes.RegisterContestant(UserInterface.GetContestantInfo(i));
            }
        }
    }
}
