using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using System;
using System.Linq;
using System.Text;
using TestDB.Data;

namespace TestDB
{
    class Program
    {
        static private ProductContext _context = new ProductContext();
        static void Main(string[] args)
        {
            Console.WriteLine("DEV BRANCH");
            Console.WriteLine("DEV BRANCH");
            Console.WriteLine("DEV BRANCH");
            Console.WriteLine("DEV BRANCH");
            Console.WriteLine("DEV BRANCH");


            Date d = Date.Now;
            DateTime dateTime = DateTime.Now;


            Console.WriteLine(d);
            Console.WriteLine(dateTime);

            var num = 5552139265672;
            Console.WriteLine(num);
        }
    }
}
