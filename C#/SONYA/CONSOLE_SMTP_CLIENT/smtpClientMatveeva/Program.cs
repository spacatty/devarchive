using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smtpClientMatveeva
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientEmail, clientPass, mailTo, mailSubject, mailBody;
            Console.WriteLine("Enter your e-mail, ex: matveeva@mail.ru");
            clientEmail = Console.ReadLine();
            Console.WriteLine("Enter your e-mail password: ex: xxxxxx");
            clientPass = Console.ReadLine();
            Console.WriteLine("Enter reciever's e-mail, ex: kuliev@gashish.ru");
            mailTo = Console.ReadLine();
            Console.WriteLine("Enter e-mail subject, ex: Hello, World!");
            mailSubject = Console.ReadLine();
            Console.WriteLine("Enter e-mail's body: ex. Corona getting crazy, dead Putin, pls gimme money!");
            mailBody = Console.ReadLine();
            MailMessage message = new MailMessage(clientEmail, mailTo, mailSubject, mailBody);
            SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(clientEmail, clientPass);
            try
            {
                client.Send(message);
                Console.WriteLine("Message has been successfully sent!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("We've got really hard issues, plz contact Allah! ", ex);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
