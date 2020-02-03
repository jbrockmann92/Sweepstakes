using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MimeKit;

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
                    //Would be method to send email here I think
                    winnerName = contestant.Value.firstName;
                    continue;
                }
            }
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value.isWinner == false)
                {
                    Console.WriteLine($"You didn't win this time! {winnerName} is the winner. Better luck next time!");
                    //Same thing here. Would probably send email here instead of printing to console
                }
            }
        }

        public void SendEmail(Contestant contestant)
        {
            var message = new MimeMessage();
            var bodyBuilder = new BodyBuilder();

            // from
            message.From.Add(new MailboxAddress("from_name", "from_email@example.com"));
            // to
            message.To.Add(new MailboxAddress("to_name", "to_email@example.com"));
            // reply to
            message.ReplyTo.Add(new MailboxAddress("reply_name", "reply_email@example.com"));

            message.Subject = "subject";
            bodyBuilder.HtmlBody = "html body";
            message.Body = bodyBuilder.ToMessageBody();

            var client = new SmtpClient();
            //What does this do?

            client.Connect("MAIL_SERVER", 465, SecureSocketOptions.SslOnConnect);
            client.Authenticate("USERNAME", "PASSWORD");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
