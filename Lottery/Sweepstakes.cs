using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

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
                    SendEmail(contestant);
                    continue;
                }
            }
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == false)
                {
                    Console.WriteLine($"You didn't win this time! {winnerName} is the winner. Better luck next time!");
                    SendEmail(contestant);
                }
            }
        }

        public void SendEmail(KeyValuePair<int, Contestant> contestant)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Jacob", "no_reply@bigwinnersweepstakes.com"));
            message.To.Add(new MailboxAddress($"{contestant.Value.firstName} {contestant.Value.lastName}", $"{contestant.Value.email}"));
            //message.ReplyTo.Add(new MailboxAddress("reply_name", "reply_email@example.com"));
            //Don't need a reply email

            message.Subject = "subject";
            if (contestant.Value.isWinner == true)
                message.Body = new TextPart("plain")
                {
                    Text = $"Congratulations {contestant.Value.firstName}, you won the contest."
                };
            else
                message.Body = new TextPart("plain")
                {
                    Text = $"Better luck next time, {contestant.Value.firstName}, won the contest."
                };

            var client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587);
            client.Authenticate("no_reply@bigwinnersweepstakes.com", "Password");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
