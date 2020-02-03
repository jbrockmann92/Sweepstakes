using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class Sweepstakes : INotifier
    {
        public Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.Name = name;
        }

        public void RegisterContestant(Contestant contestant)
        { 
            //Something here or in interface about how many contestants they'd like to add? Not part of User Stories though
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

            //This can work if I just assign registration numbers in ascending order
            //Random rnd = new Random();
            //contestant = contestants[rnd.Next(1, contestants.Count)];
            //return contestant;
        }

        public void PrintcontestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is {contestant.firstName}, {contestant.lastName}!");
        }

        public void Notify()
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == true)
                {
                    Console.WriteLine("You're the winner! Congratulations!");
                }
                else
                {
                    Console.WriteLine($"You didn't win this time! { } is the winner. Better luck next time!");
//How to print that the one who won is the winner info?
                }
            }
            //Logic to notify winner and losers. Bool that determines if they're a winner or not. Have the bool set when the winner is chosen
        }
    }
}
