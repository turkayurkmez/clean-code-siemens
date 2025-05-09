using CleanCode;
using CleanCode.Business;
using CleanCode.Entities;
using CleanCode.Infrastructure;

class Program
{
    static void Main(string[] args)
    {


        List<TimeSheetEntry> timeSheetEntries = GetTimeSheetEntries();
        
        MailSender mailSender = new MailSender();
        BillTool billTool = new BillTool();
        PaymentCalculator calculator = new PaymentCalculator(mailSender,billTool);
        calculator.CalculateBillAndSendMail(timeSheetEntries);
        ExtraPaymentOptions extraPaymentOptions = new ExtraPaymentOptions()
        {
            MaxHoursInAWeek = 40,
            ExtraPrice = 15,
            StandartPrice = 10


        };
        double extraPayment = calculator.GetExtraPayment(timeSheetEntries,extraPaymentOptions);
        Console.WriteLine("You will get paid $" + extraPayment + " for your time.");
        Console.WriteLine();
        Console.Write("Press any key to exit application...");
        Console.ReadKey();
    }

    static List<TimeSheetEntry> GetTimeSheetEntries()
    {


        List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
        do
        {

            Console.Write("Enter what you did: ");
            string workDescription = Console.ReadLine();
            double timeForWork = getTimeDoubleFormat();

            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeForWork,
                WorkDone = workDescription
            };
            timeSheetEntries.Add(timeSheetEntry);
            Console.Write("Do you want to enter more time (yes/no): ");

            string answer = Console.ReadLine();
            if (answer.ToLower() != UserAnswers.YES)
                break;

        }
        while (true);

        return timeSheetEntries;
    }

    static double getTimeDoubleFormat()
    {
        double timeForWork;
        do
        {
            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();


            if (!double.TryParse(rawTimeWorked, out timeForWork))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
            }
            else
            {
                return timeForWork;
            }
        } while (true);





    }

   

  


    
}
