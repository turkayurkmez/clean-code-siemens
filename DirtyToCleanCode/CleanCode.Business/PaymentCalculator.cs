using CleanCode.Entities;
using CleanCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Business
{
    public class PaymentCalculator
    {
        private IMailSender _mailSender;
        private IBillTool _billTool;

        public PaymentCalculator(IMailSender mailSender, IBillTool billTool)
        {
            _mailSender = mailSender;
            _billTool = billTool;
        }
        public double GetExtraPayment(List<TimeSheetEntry> timeSheetEntries, ExtraPaymentOptions options)
        {
            var totalHours = timeSheetEntries.Sum(x => x.HoursWorked);
            double extraTotal = 0;
            double extraPayment = (totalHours - options.MaxHoursInAWeek) * options.ExtraPrice;
            double standardPayment = options.MaxHoursInAWeek * options.StandartPrice;
            extraTotal = extraPayment + standardPayment;

            //if (totalHours > maxHoursInAWeek)
            //{


            //     extraTotal = extraPayment + standardPayment;
            //    Console.WriteLine("You will get paid $" + totalPayment + " for your work.");
            //}
            //else
            //{
            //    totalPayment = totalHours * standardPrice;
            //    Console.WriteLine("You will get paid $" + totalPayment + " for your time.");
            //}


            return Math.Max(extraTotal, (totalHours - options.MaxHoursInAWeek) * options.StandartPrice);
        }

        public void CalculateBillAndSendMail(List<TimeSheetEntry> timeSheetEntries)
        {
            List<Company> companies = new CompanyService().GetCompanies();

            foreach (Company company in companies)
            {             
                double bill = _billTool.GetTotalBillForWeek(timeSheetEntries, company);
                //MailSender mailSender = new MailSender();
                _mailSender.SendEmail(timeSheetEntries, company.Name, bill);
            }
        }
    }
}
