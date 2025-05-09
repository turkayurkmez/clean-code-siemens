using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Infrastructure
{
    public class MailSender : IMailSender
    {
        public void SendEmail(List<TimeSheetEntry> timeSheetEntries, string companyName, double billingValue)
        {
            // double billForCompany = getTotalBillForWeek(timeSheetEntries, companyName, hourlyPrice);
            Console.WriteLine($"Simulating Sending email to {companyName}");
            Console.WriteLine("Your bill is $" + billingValue + " for the hours worked.");
        }
    }
}
