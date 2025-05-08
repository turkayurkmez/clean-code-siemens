using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Exceptions
{
    public class ExcelFormatException : Exception
    {
        public string AvailableFormatDescription { get; set; }
        public ExcelFormatException(string message):base(message) 
        { 

        }
        public ExcelFormatException(string message, string availableFormatDesc): base(message)
        {
            AvailableFormatDescription = availableFormatDesc;
        }



    }
}
