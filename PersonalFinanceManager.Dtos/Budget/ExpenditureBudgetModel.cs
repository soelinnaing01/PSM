using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Dtos.Budget
{
    public class ExpenditureBudgetModel
    {
        public DateTime Month { get; set; }
        public decimal Amount { get; set; }
    }
}
