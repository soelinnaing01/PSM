using Newtonsoft.Json.Linq;
using PersonalFinanceManager.Dtos.Dashboard;
using PersonalFinanceManager.Dtos.Enums;
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
            return _dapperService.QueryFirstOrDefault<decimal>(SqlQuery.DashboardQuery.Balance, CommandType.StoredProcedure);
        }

        public FunctionResponseModel Functions()
        {
            FunctionResponseModel model = new FunctionResponseModel();

            var lst = new List<FunctionModel>
            {
                new FunctionModel("F001", "Income", "Income Type", "Income Source", "Payment"),
                new FunctionModel("F002", "Expense", "Expense Type", "Expense Destination", "Payment"),
                new FunctionModel("F003", "Budget", "Overall", "Budget Exceed Expense"),
                new FunctionModel("F004", "Saving", "Overall", "By User"),
                new FunctionModel("F005", "Withdrawal", "Overall", "By User")
            };

            model.Functions = lst;
            return model;
        }

        public List<FunctionItemModel> FunctionItems(string functionCode)
        {
            return Functions().Functions.First(x => x.FunctionCode == functionCode).FunctionItems;
        }

        public FunctionItemModel FunctionItem(string functionCode, string functionItemCode)
        {
            return Functions()
                .Functions
                .First(x => x.FunctionCode == functionCode)
                .FunctionItems
                .First(x => x.FunctionItemCode == functionItemCode);
        }

        public DataTableResponseModel Report(string functionCode, string functionItemCode, EnumDashboardReportType reportType)
        {
            var functionItem = FunctionItem(functionCode, functionItemCode);
            DataTableResponseModel model = new DataTableResponseModel();
            try
            {
                string storedProcedureName = $"Get{functionItem.FunctionItemName.Replace(" ", "")}AverageBy{reportType}";
                DataTable dt = _dapperService
                    .QueryDataTableStoredProcedure(storedProcedureName);

                model.Data = dt;
                model.Message = "Success!";
                model.IsSuccess = true;
            }
            catch
            {
                model.Message = "Not availabe currently. It might be coming soon!";
                model.IsSuccess = false;
            }
            return model;
        }
    }
}
