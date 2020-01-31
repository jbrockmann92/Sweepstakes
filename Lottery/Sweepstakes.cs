using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sweepstakes(string name)
        {
            this.Name = name;
        }

        public void RegisterContestant(Contestant contestant)
        { 
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Contestant contestant;
            //Need to go through each of the registrationNumbers and choose one randomly.
            //Generate, then find the closest Contestant ID to the generated number?
            //Easy to find the lowest one I guess. Can change later if time
            int winningContestant = contestants.Keys.Min();
            if (contestants.TryGetValue(winningContestant, out contestant))
                return contestant;
            else
                return contestant;
            //I think this should work
        }

        public void PrintcontestantInfo(Contestant contestant) //Enter PickWinner into this? Seems like bad practice. Maybe in the MarketingFirm class?
        {
            Console.WriteLine($"The winner is {contestant.firstName}, {contestant.lastName}!");
        }
    }
}
