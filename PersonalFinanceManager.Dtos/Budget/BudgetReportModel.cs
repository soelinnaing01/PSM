using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Dtos.Budget
{
    public class BudgetReportModel
    {
        public string YearMonth { get; set; }
        public decimal Amount { get; set; }
    }
}
