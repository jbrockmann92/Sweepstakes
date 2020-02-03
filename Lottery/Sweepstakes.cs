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
            
            Random rnd = new Random();
            contestant = contestants[rnd.Next(1, contestants.Count)];
            return contestant;
        }

        public void PrintcontestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is {contestant.firstName}, {contestant.lastName}!");
        }

        public void Notify()
        {
            string winnerName = "";
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == true)
                {
                    Console.WriteLine("You're the winner! Congratulations!");
                    winnerName = contestant.Value.firstName;
                    continue;
                }
            }
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == false)
                {
                    Console.WriteLine($"You didn't win this time! {winnerName} is the winner. Better luck next time!");
                }
            }
        }
    }
}
