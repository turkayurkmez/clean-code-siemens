using CleanCode.Entities;

namespace CleanCode.Business
{
    public interface IBillTool
    {
        double GetTotalBillForWeek(List<TimeSheetEntry> timeSheetEntries, Company company);
    }
}