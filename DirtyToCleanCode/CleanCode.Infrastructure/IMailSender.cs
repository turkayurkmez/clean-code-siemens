using CleanCode.Entities;

namespace CleanCode.Infrastructure
{
    public interface IMailSender
    {
        void SendEmail(List<TimeSheetEntry> timeSheetEntries, string companyName, double billingValue);
    }
}
