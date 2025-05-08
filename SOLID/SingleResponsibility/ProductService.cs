using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True";
        public int  CreateProduct(string name, decimal price)
        {
           
            string commandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string,object> parameters = new Dictionary<string,object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            SqlProvider sqlProvider = new SqlProvider(connectionString);
            int affected = sqlProvider.ExecuteNonQuery(commandText, parameters);        

            return affected;


           
            
        }
    }
}
