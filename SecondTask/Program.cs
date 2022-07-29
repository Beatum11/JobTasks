using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SecondTask
{
    internal class Program
    {

       

        static void Main(string[] args)
        {

            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "TestDb",
                IntegratedSecurity = true,
                Pooling = false
            };

            Console.WriteLine($"Строка подключения: {strCon.ConnectionString}");

            SqlConnection sqlConnect = new SqlConnection()
            { ConnectionString = strCon.ConnectionString };

            //sqlConnect.Open();

            



            Console.ReadKey();

        }
    }
}
