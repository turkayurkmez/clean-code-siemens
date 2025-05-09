using CleanCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Business
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
           {
               new Company(){ Name="Acme", HourlyPrice = 150},
               new Company(){ Name="ABC", HourlyPrice = 125}

            };
        }
    }
}
