using PersonalFinanceManager.Dtos.Enums;
using PersonalFinanceManager.Services;
using PersonalFinanceManager.Services.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class frm_dashboard : Form
    {
        private reporting rpt;
        int condition;

        private readonly DashboardService _dashboardService;

        public frm_dashboard()
        {
            InitializeComponent();

            _dashboardService = new DashboardService();

            btnIncome.Tag = EnumFunctionType.Income.ToString();
            btnExpense.Tag = EnumFunctionType.Expense.ToString();
            btnBudget.Tag = EnumFunctionType.Budget.ToString();
            btnSaving.Tag = EnumFunctionType.Saving.ToString();

            cbo_function.ValueMember = "FunctionCode";
            cbo_function.DisplayMember = "FunctionName";
            cbo_function.DataSource = _dashboardService.Functions().Functions;

            this.KeyPreview = true;
            this.KeyDown += frm_home_KeyDown;
            rdo_yearly.CheckedChanged += rdo_CheckedChangeClearControls;
            rdo_monthly.CheckedChanged += rdo_CheckedChangeClearControls;
        }

        private void frm_home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void balanceRefresh()
        {
            lbl_balance.Text = _dashboardService
                .Balance()
                .ToThousandSeparator() + " -MMK";
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Program.name;
            rdo_yearly.Checked = true;
            balanceRefresh();
        }

        private void OnFunctionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var functionType = button.Tag.ToString().ToEnum<EnumFunctionType>();
            switch (functionType)
            {
                case EnumFunctionType.Income:
                    frm_income income = new frm_income(this);
                    income.ShowDialog();
                    break;
                case EnumFunctionType.Expense:
                    frm_expense expense = new frm_expense(this);
                    expense.ShowDialog();
                    break;
                case EnumFunctionType.Budget:
                    frm_budget budget = new frm_budget(this);
                    budget.ShowDialog();
                    break;
                case EnumFunctionType.Saving:
                    frm_saving saving = new frm_saving(this);
                    saving.ShowDialog();
                    break;
                case EnumFunctionType.None:
                default:
                    break;
            }
        }

        private void btn_refersh_Click(object sender, EventArgs e)
        {
            balanceRefresh();
        }

        private void frm_home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;
                btn_refersh.PerformClick();
                e.Handled = true;
            }
        }

        private void rdo_CheckedChangeClearControls(object sender, EventArgs e)
        {
            dgv_report.DataSource = null;
            pnl_chart.Controls.Clear();
            cbo_title.SelectedItem = null;
            cbo_function.SelectedItem = null;
        }

        private void cbo_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbo_title.SelectedItem = null;
            //cbo_title.Items.Clear();

            dgv_report.DataSource = null;

            pnl_chart.Controls.Clear();

            if (cbo_function.SelectedValue == null) return;

            string functionCode = cbo_function.SelectedValue.ToString();
            cbo_title.ValueMember = "FunctionItemCode";
            cbo_title.DisplayMember = "FunctionItemName";
            cbo_title.DataSource = _dashboardService.FunctionItems(functionCode);

            //switch (cbo_function.SelectedIndex)
            //{
            //    case 0://Income
            //        cbo_title.Items.AddRange(new string[] { "Income Type", "Income Source", "Payment" });
            //        condition = rdo_yearly.Checked ? 1 : 2;
            //        break;
            //    case 1://Expense
            //        cbo_title.Items.AddRange(new string[] { "Expense Type", "Expense Destination", "Payment" });
            //        condition = rdo_yearly.Checked ? 3 : 4;
            //        break;
            //    case 2://Budget
            //        cbo_title.Items.AddRange(new string[] { "Overall", "Budget Exceed Expense" });
            //        condition = rdo_yearly.Checked ? 5 : 6;
            //        break;
            //    case 3://Saving
            //        condition = rdo_yearly.Checked ? 7 : 8;
            //        break;
            //    case 4://Withdrawal                   
            //        condition = rdo_yearly.Checked ? 9 : 10;
            //        break;
            //}
            //if (condition == 7 || condition == 8 || condition == 9 || condition == 10)
            //{
            //    cbo_title.Items.AddRange(new string[] { "Overall", "By User" });
            //}
        }

        private void cbo_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_function.SelectedValue == null ||
                cbo_title.SelectedValue == null) return;

            var model = _dashboardService.Report(
                cbo_function.SelectedValue.ToString(),
                cbo_title.SelectedValue.ToString(),
                rdo_yearly.Checked ? EnumDashboardReportType.Yearly : EnumDashboardReportType.Monthly
                );

            pnl_chart.Controls.Clear();
            dgv_report.DataSource = null;

            if (model.IsError)
            {
                Alert.ErrorMessage(model.Message);
                return;
            }

            reporting.GetLineChart(pnl_chart, model.Data);
            dgv_report.DataSource = model.Data;

            //switch (condition)
            //{
            //    case 1:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = "EXEC GetIncomeTypeAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetIncomeSourceAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 2:
            //                DB.sql = "EXEC GetPaymentMethodAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //        }
            //        break;

            //    case 2:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = "EXEC GetIncomeTypeAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetIncomeSourceAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 2:
            //                DB.sql = "EXEC GetPaymentMethodAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //        }
            //        break;
            //    case 3:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = "EXEC GetExpenseTypeAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetExpenseDestinationAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 2:
            //                DB.sql = "EXEC GetExpensePaymentMethodAverageByYearly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //        }
            //        break;
            //    case 4:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = "EXEC GetExpenseTypeAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetExpenseDestinationAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //            case 2:
            //                DB.sql = "EXEC GetExpensePaymentMethodAverageByMonthly";
            //                reporting.GetLineChart(pnl_chart);
            //                break;
            //        }
            //        break;
            //    case 5:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                MessageBox.Show("Not availabe currently.It might be coming soon!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetExceedingBudgetMonthsByYearly";
            //                reporting.GetBarChart(pnl_chart);
            //                break;
            //        }
            //        break;
            //    case 6:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                MessageBox.Show("Not availabe currently. It might be coming soon!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                break;
            //            case 1:
            //                DB.sql = "EXEC GetCurrentYearExceedingBudgetMonths";
            //                reporting.GetBarChartMonth(pnl_chart);
            //                break;
            //        }
            //        break;
            //    case 7:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                break;
            //            case 1:
            //                DB.sql = null;
            //                break;
            //        }
            //        break;
            //    case 8:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                break;
            //            case 1:
            //                DB.sql = null;
            //                break;
            //        }
            //        break;
            //    case 9:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                break;
            //            case 1:
            //                DB.sql = null;
            //                break;
            //        }
            //        break;
            //    case 10:
            //        switch (cbo_title.SelectedIndex)
            //        {
            //            case 0:
            //                DB.sql = null;
            //                break;
            //            case 1:
            //                DB.sql = null;
            //                break;
            //        }
            //        break;

            //}
            //DataTable dt = reporting.dataTable;
            //dgv_report.DataSource = dt;
        }
    }
}
