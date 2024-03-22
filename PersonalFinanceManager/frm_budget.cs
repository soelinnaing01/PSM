using PersonalFinanceManager.Dtos.Budget;
using PersonalFinanceManager.Query;
using PersonalFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class frm_budget : Form
    {
        private frm_home homeForm;
        private readonly DapperService _dapperService;
        public frm_budget(frm_home home)
        {
            homeForm = home;
            InitializeComponent();
            _dapperService = new DapperService();
        }
        TextBox Txb;
        private void btn_addbudget_ClickV1(object sender, EventArgs e)
        {
            bool messageShown = validate.TextCheck(groupBox1);
            if (messageShown)
                return;

            dgv_budget.DataSource = null;
            DateTime Date = dtpk_budget.Value;
            string formattedDate = Date.ToString("yyyy-MM-dd");
            Decimal amount;
            if (Decimal.TryParse(txt_amount.Text, out amount))
            {
                amount = Decimal.Parse(txt_amount.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal number.", "Invalid Fromat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int insertedId = -1;
            try
            {
                string message = "New budget added successfully!";
                DB.sql = "EXEC AddExpenditureBudget @month = '" + formattedDate + "',@amount = '" + amount + "',@insertedId = @insertedId OUTPUT";
                DB.DoInsert(message, out insertedId);
                if (insertedId != -1)
                {
                    DB.sql = "SELECT month, amount FROM expenditure_budgets WHERE id = " + insertedId;
                    DataTable dt = DB.GetDataTable();
                    dgv_budget.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addbudget_Click(object sender, EventArgs e)
        {
            try
            {
                bool messageShown = validate.TextCheck(groupBox1);
                if (messageShown)
                    goto result;

                dgv_budget.DataSource = null;
                string formattedDate = dtpk_budget.Value.ToString("yyyy-MM-dd");
                decimal amount;
                if (!decimal.TryParse(txt_amount.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid decimal number.", "Invalid Fromat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto result;
                }
                amount = txt_amount.Text.ToInt32();
                int result = AddExpenditureBudget(formattedDate, amount);
                if (result == -1) goto result;
                GetBudgetLst(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        result:
            return;
        }

        private int AddExpenditureBudget(string formattedDate, decimal amount)
        {
            var budgetParam = new
            {
                FormattedDate = formattedDate,
                Amount = amount,
            };
            var result = _dapperService
                .Execute(SqlQuery.Budget.AddExpenditureBudget,
                budgetParam, CommandType.StoredProcedure);
            return result;
        }

        private void GetBudgetLst(int result)
        {
            string message = "New budget added successfully!";
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var getBudgetParam = new
            {
                InsertedId = result
            };
            var budgetLst = _dapperService
                .Query<ExpenditureBudgetModel>
                (SqlQuery.Budget.GetExpenditureBudget, getBudgetParam);
            dgv_budget.DataSource = budgetLst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_search.Controls.Clear();
            dgv_budget.DataSource = null;
            TextBox txb = new TextBox();
            pnl_search.Controls.Add(txb);
            Txb = txb;
            txb.KeyPress -= keycontrol.AllowOnlyLetters;
            txb.KeyPress -= keycontrol.AllowOnlyNumbers;
            if (comboBox1.SelectedIndex == 0)
            {
                txb.KeyPress += keycontrol.AllowOnlyNumbers;
            };
            if (comboBox1.SelectedIndex == 1)
            {
                txb.KeyPress += keycontrol.AllowOnlyLetters;
            };
            txb.TextChanged += Txb_TextChanged;
        }
        private void Txb_TextChanged(Object sender, EventArgs e)
        {
            dgv_budget.DataSource = comboBox1.SelectedIndex == 0 ?
                GetBudgetByYear() : GetBudgetByMonthOfCurrentYear();
        }

        private List<BudgetReportModel> GetBudgetByMonthOfCurrentYear()
        {
            var budgetLst = new List<BudgetReportModel>();
            if (!string.IsNullOrEmpty(Txb.Text))
            {
                var obj = new
                {
                    Month = Txb.Text.Trim()
                };
                budgetLst = _dapperService
                    .Query<BudgetReportModel>
                    (SqlQuery.Budget.GetBudgetByMonthOfCurrentYear, obj,
                    CommandType.StoredProcedure);
                //month = Txb.Text.Trim();
                //DB.sql = "EXEC GetBudgetByMonthOfCurrentYear @monthName = " + month;
            }
            return budgetLst;
        }

        private List<BudgetReportModel> GetBudgetByYear()
        {
            var budgetLst = new List<BudgetReportModel>();
            int year;
            if (int.TryParse(Txb.Text, out year))
            {
                var obj = new
                {
                    YearPattern = year.ToString()
                };
                budgetLst = _dapperService
                    .Query<BudgetReportModel>
                    (SqlQuery.Budget.GetBudgetByYear, obj,
                    CommandType.StoredProcedure);
                //string yearpattern = year.ToString();
                //DB.sql = "EXEC GetBudgetByYear @yearPattern = " + yearpattern;
            }
            return budgetLst;
        }

        private void frm_budget_Load(object sender, EventArgs e)
        {
            //dgv_budget.DataSource = null;
            //DB.sql = "EXEC LoadAllBudgets";
            //DataTable dt = DB.GetDataTable();
            //dgv_budget.DataSource = dt;
            dgv_budget.DataSource = _dapperService
                .Query<BudgetReportModel>
                (SqlQuery.Budget.LoadAllBudgets, commandType: CommandType.StoredProcedure);
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender, e, btn_addbudget);
        }
    }
}
