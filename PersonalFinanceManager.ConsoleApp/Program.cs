using PersonalFinanceManager.Services.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");

            DashboardService dashboardService = new DashboardService();
            var balance = dashboardService.Balance();
            Console.WriteLine(balance);

            Console.ReadKey();
        }
    }
}
