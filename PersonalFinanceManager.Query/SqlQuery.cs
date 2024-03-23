using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Query
{
    public class SqlQuery
    {
        public static class LoginQuery
        {
            public static string Login { get; } = "Login";
        }

        public static class DashboardQuery
        {
            public static string Balance { get; } = "LoadBalance";
        }

        public static class AddNewDataQuery
        {
            public static string AddDescription { get; } = @"InsertDescription @name = @description";
            public static string GetDescription { get; } = @"SELECT Description FROM descriptions;";
            public static string AddFromToFlow { get; } = @"InsertFromToFlow @name = @description";
            public static string GetFromToFlow { get; } = @"SELECT Text FROM from_to_flow;";
            public static string AddCashFlow { get; } = @"InsertCashFlow @name = @description;";
            public static string GetCashFlow { get; } = @"SELECT Text FROM cash_flow;";
        }

        public static class BudgetQuery
        {
            public static string AddExpenditureBudget { get; } = @"AddExpenditureBudget 
        @month = @FormattedDate ,@amount =  @Amount ,
        @insertedId = @InsertedId OUTPUT";

            public static string GetExpenditureBudget { get; } = @"SELECT Month, Amount 
         FROM expenditure_budgets WHERE id = @InsertedId";

            public static string GetBudgetByYear { get; } = @"GetBudgetByYear 
         @yearPattern = @YearPattern";

            public static string GetBudgetByMonthOfCurrentYear { get; } = @"GetBudgetByMonthOfCurrentYear
        @monthName = @Month";

            public static string LoadAllBudgets { get; } = @"LoadAllBudgets";
        }
    }
}
