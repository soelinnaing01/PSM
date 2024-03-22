using PersonalFinanceManager.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Services.Features
{
    public class DashboardService
    {
        private readonly DapperService _dapperService;

        public DashboardService()
        {
            _dapperService = new DapperService();
        }

        public decimal Balance()
        {
            return _dapperService.QueryFirstOrDefault<decimal>(SqlQuery.Dashboard.Balance, CommandType.StoredProcedure);
        }
    }
}
