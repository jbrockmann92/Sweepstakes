using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class MarketingFirm
    {
        //Highest level class
        ISweepstakesManager manager;

        MarketingFirm(ISweepstakesManager manager)
        {

        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            sweepstakes.RegisterContestant(UserInterface.GetContestantInfo());
        }
    }
}
