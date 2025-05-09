using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Business
{
    public class BillTool : IBillTool
    {
        public double GetTotalBillForWeek(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalHours = 0;
            //for (int i = 0; i < timeSheetEntries.Count; i++)
            //{
            //    if (timeSheetEntries[i].WorkDone.ToLower().Contains(companyName.ToLower()))
            //    {
            //        totalHours += timeSheetEntries[i].HoursWorked;
            //    }
            //}

            //foreach (var item in timeSheetEntries)
            //{
            //    if (item.WorkDone.ToLower().Contains(companyName.ToLower()))
            //    {
            //        totalHours += timeSheetEntries[i].HoursWorked;
            //    }
            //}

            totalHours = timeSheetEntries.Where(x => x.WorkDone.ToLower().Contains(company.Name.ToLower()))
                                         .Sum(x => x.HoursWorked);

            return totalHours * company.HourlyPrice;
        }
    }
}
