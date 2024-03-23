using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Dtos.Dashboard
{
    public class FunctionModel
    {
        public FunctionModel(string functionCode, string functionName, params string[] functionItems)
        {
            FunctionCode = functionCode;
            FunctionName = functionName;
            FunctionItems = functionItems.Select((x, i) => new FunctionItemModel
            {
                FunctionCode = functionCode,
                FunctionItemCode = functionCode + "_" + i.ToString().PadLeft(2, '0'),
                FunctionItemName = x
            }).ToList();
        }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public List<FunctionItemModel> FunctionItems { get; set; }
    }

    public class FunctionItemModel
    {
        public string FunctionCode { get; set; }
        public string FunctionItemCode { get; set; }
        public string FunctionItemName { get; set; }
    }

    public class FunctionResponseModel
    {
        public List<FunctionModel> Functions { get; set; }
    }

    public class DataTableResponseModel
    {
        public bool IsSuccess { get; set; }
        public bool IsError { get { return !IsSuccess; } }
        public string Message { get; set; }
        public DataTable Data { get; set; }
    }
}
