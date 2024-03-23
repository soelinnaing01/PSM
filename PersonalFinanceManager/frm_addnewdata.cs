using PersonalFinanceManager.Dtos.AddNewData;
using PersonalFinanceManager.Query;
using PersonalFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class frm_addnewdata : Form
    {
        public frm_income IncomeForm { get; set; }
        public frm_expense ExpenseForm { get; set; }

        private readonly DapperService _dapperService;

        public frm_addnewdata()
        {
            InitializeComponent();
            _dapperService = new DapperService();
        }

        public string labelName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender, e, button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    //string nextsql;
                    //string data = textBox1.Text.ToString();
                    //DB.sql = "EXEC InsertDescription @name = '" + data + "';";
                    var descParam = new
                    {
                        description = textBox1.Text.ToString()
                    };
                    var result = _dapperService.Execute(SqlQuery.AddNewDataQuery.AddDescription, descParam, CommandType.StoredProcedure);
                    #region commented codes
                    //if (label1.Text == "Income Title :" || label1.Text == "Expense Title :")
                    //{
                    //    IncomeTitleComboBox();
                    //    //nextsql = "SELECT description FROM descriptions;";
                    //    //SqlDataReader dr = DB.InsertTitles(nextsql);

                    //    //if (dr != null)
                    //    //{
                    //    //    if (label1.Text == "Income Title :")
                    //    //    {
                    //    //        IncomeForm.Cob1.Items.Clear();
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            IncomeForm.Cob1.Items.Add(dr["description"].ToString());
                    //    //        }
                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        ExpenseForm.Cob1.Items.Clear();
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            ExpenseForm.Cob1.Items.Add((string)dr["description"].ToString());
                    //    //        }
                    //    //    }

                    //    //}
                    //}
                    //else if (label1.Text == "From :" || label1.Text == "To :")
                    //{

                    //    FlowToFromComboBox(descParam);
                    //    //nextsql = "SELECT text FROM from_to_flow;";
                    //    //DB.sql = "EXEC InsertFromToFlow @name = '" + data + "';";
                    //    //SqlDataReader dr = DB.InsertTitles(nextsql);


                    //    //if (dr != null)
                    //    //{
                    //    //    if (label1.Text == "From :")
                    //    //    {
                    //    //        IncomeForm.Cob2.Items.Clear();
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            IncomeForm.Cob2.Items.Add(dr["text"].ToString());
                    //    //        }
                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            ExpenseForm.Cob2.Items.Clear();
                    //    //            while (dr.Read())
                    //    //            {
                    //    //                ExpenseForm.Cob2.Items.Add(dr["text"].ToString());
                    //    //            }
                    //    //        }
                    //    //    }

                    //    //}
                    //}
                    //else if (label1.Text == "IncomeType :" || label1.Text == "Payment :")
                    //{
                    //    CashFlowComboBox(descParam);
                    //    //nextsql = "SELECT text FROM cash_flow;";
                    //    //DB.sql = "EXEC InsertCashFlow @name = '" + data + "';";
                    //    //SqlDataReader dr = DB.InsertTitles(nextsql);
                    //    //if (dr != null)
                    //    //{
                    //    //    if (label1.Text == "IncomeType :")
                    //    //    {
                    //    //        IncomeForm.Cob3.Items.Clear();
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            IncomeForm.Cob3.Items.Add(dr["text"].ToString());
                    //    //        }
                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        ExpenseForm.Cob3.Items.Clear();
                    //    //        while (dr.Read())
                    //    //        {
                    //    //            ExpenseForm.Cob3.Items.Add(dr["text"].ToString());
                    //    //        }
                    //    //    }

                    //    //}
                    //}
                    #endregion
                    switch (label1.Text)
                    {
                        case "Income Title :":
                        case "Expense Title :":
                            IncomeTitleComboBox();
                            break;
                        case "From :":
                        case "To :":
                            FlowToFromComboBox(descParam);
                            break;
                        case "IncomeType :":
                        case "Payment :":
                            CashFlowComboBox(descParam);
                            break;
                        default:
                            throw new Exception($"Not Found label1.Text{label1.Text}");
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        private void IncomeTitleComboBox()
        {
            var descriptionLst = _dapperService
                        .Query<DescriptionModel>(SqlQuery.AddNewDataQuery.GetDescription);
            if (descriptionLst is null) return;
            if (label1.Text == "Income Title :")
            {
                IncomeForm.Cob1.Items.Clear();
                IncomeForm.Cob1.Items.AddRange(descriptionLst.ToArray());
            }
            else
            {
                ExpenseForm.Cob1.Items.Clear();
                ExpenseForm.Cob1.Items.AddRange(descriptionLst.ToArray());
            }
        }

        private void FlowToFromComboBox(object descParam)
        {
            var result = _dapperService.Execute(SqlQuery.AddNewDataQuery.AddFromToFlow, descParam, CommandType.StoredProcedure);
            var flowToFormLst = _dapperService
                .Query<FlowToFormModel>(SqlQuery.AddNewDataQuery.GetFromToFlow);
            if (flowToFormLst is null) return;

            if (label1.Text == "From :")
            {
                IncomeForm.Cob2.Items.Clear();
                IncomeForm.Cob2.Items.AddRange(flowToFormLst.ToArray());
            }
            else
            {
                ExpenseForm.Cob2.Items.Clear();
                ExpenseForm.Cob2.Items.AddRange(flowToFormLst.ToArray());
            }
        }

        private void CashFlowComboBox(object descParam)
        {
            var result = _dapperService.Execute(SqlQuery.AddNewDataQuery.AddCashFlow, descParam, CommandType.StoredProcedure);
            var cashFlowLst = _dapperService
                .Query<CashFlowModel>(SqlQuery.AddNewDataQuery.GetCashFlow);
            if (cashFlowLst is null) return;

            if (label1.Text == "IncomeType :")
            {
                IncomeForm.Cob3.Items.Clear();
                IncomeForm.Cob3.Items.AddRange(cashFlowLst.ToArray());
            }
            else
            {
                ExpenseForm.Cob3.Items.Clear();
                ExpenseForm.Cob3.Items.AddRange(cashFlowLst.ToArray());
            }
        }
    }
}
