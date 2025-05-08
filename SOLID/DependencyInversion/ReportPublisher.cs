using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ReportPublisher
    {
        //public MailSender Sender { get; set; }
        private ISender sender;

        public ReportPublisher(ISender sender)
        {
            this.sender = sender;
        }
        public void Send()
        {
            //MailSender sender = new MailSender();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class MailSender : ISender
    {
        public void Send() {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp...");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram");
        }
    }
}
