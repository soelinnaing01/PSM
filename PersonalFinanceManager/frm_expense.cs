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
    public partial class frm_expense : Form
    {
        private frm_home homeForm;
        DateTimePicker Dtpk;
        TextBox Txb;

        public frm_expense(frm_home home)
        {
            InitializeComponent();
            homeForm = home;
        }

        public ComboBox Cob1
        {
            get { return cbo_description; }
            set { cbo_description = value; }
        }

        public ComboBox Cob2
        {
            get { return cbo_from; }
            set { cbo_from = value; }
        }

        public ComboBox Cob3
        {
            get { return cbo_type; }
            set { cbo_type = value; }
        }

        private void frm_expense_Load(object sender, EventArgs e)
        {
            validate.ControlClear(groupBox1);
            DB.sql = "EXEC ExpenseFormLoading;";
            SqlDataReader dr = DB.GetDataReader();
            while (dr.Read())
            {
                cbo_description.Items.Add(dr["description"].ToString());
            }
            dr.NextResult();
            while (dr.Read())
            {
                cbo_from.Items.Add(dr["To"].ToString());
            }
            dr.NextResult();
            while (dr.Read())
            {
                cbo_type.Items.Add(dr["Payment"].ToString());
            }
            dr.NextResult();
            DB.sql = "EXEC GetExpense";
            DataTable dt = DB.GetDataTable();
            dgv_expense.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePicker dtpk = new DateTimePicker();
            TextBox tb = new TextBox();
            dgv_expense.DataSource = null;
            pnl_search.Controls.Clear();
            if (comboBox1.SelectedIndex == 0)
            {              
                dtpk.Format = DateTimePickerFormat.Short;
                dtpk.Value = DateTime.Now;
                pnl_search.Controls.Add(dtpk);
                dtpk.Visible = true;
                Dtpk = dtpk;
                dtpk.ValueChanged += dtpk_ValueChanged;

            }
            else
            {
                Txb = tb;
                tb.TextChanged += tb_TextChanged;
                tb.Size = pnl_search.Size;
                pnl_search.Controls.Add(tb);
            }
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            dgv_expense.DataSource = null;
            int year = Dtpk.Value.Year;
            int month = Dtpk.Value.Month;
            DB.sql = "EXEC GetExpenseByMonth @Year = '" + year + "',@Month = '" + month + "';";

            DataTable dt = DB.GetDataTable();
            dgv_expense.DataSource = dt;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            dgv_expense.DataSource = null;
            string username = Txb.Text.Trim();
            DB.sql = "EXEC GetExpenseByUser @Username = '" + username + "';";
            DataTable dt = DB.GetDataTable();
            dgv_expense.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_expense.DataSource = null;
            bool messageShown = validate.TextCheck(groupBox1);
            if (!messageShown)
            {
                string description = cbo_description.SelectedItem?.ToString();
                string FromToFlow = cbo_from.SelectedItem?.ToString();
                string User = Program.name.ToString();
                string CashFlow = cbo_type.SelectedItem?.ToString();
                decimal Amount;
                if(decimal.TryParse(txt_amount.Text, out Amount))
                {
                    Amount = Decimal.Parse(txt_amount.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a valid decimal number.", "Invalid Fromat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime Date = dateTimePicker1.Value;
                string formattedDate = Date.ToString("yyyy-MM-dd");

                int insertedId = -1;
                int StatusCode = -1;
                try
                {
                    DB.sql = "EXEC CheckBudgetAndBalance @Description = '" + description + "', @FromToFlow = '" + FromToFlow + "'," +
                        "@CashFlow = '" + CashFlow + "', @Amount = " + Amount + ", @Date = '" + formattedDate + "', @StatusCode =@StatusCode OUTPUT";

                    DB.CheckBalanceAndBudget(out StatusCode);
                    bool yes = false;
                    if (StatusCode == 2)
                    {
                       DialogResult res = MessageBox.Show("Your expense is exceed for current month. Are you sure want to ahead?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(res == DialogResult.Yes)
                        {
                            yes = true;
                        };
                        
                    };
                    if (yes == true || StatusCode !=2)
                    {
                        DB.sql = "EXEC AddNewExpense @Description = '" + description + "', @FromToFlow = '" + FromToFlow + "', @User = '" + User + "', " +
                              "@CashFlow = '" + CashFlow + "', @Amount = " + Amount + ", @Date = '" + formattedDate + "', @InsertedId = @InsertedId OUTPUT";
                        DialogResult result = MessageBox.Show("Are you sure want to add Expense?", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            try
                            {
                                string message = "New Expense added succesfully";
                                DB.DoInsert(message,out insertedId);
                                homeForm.balanceRefresh();
                                if (insertedId != -1)
                                {
                                    try
                                    {
                                        DB.sql = $"SELECT descriptions.description AS Description, from_to_flow.text AS [To], cash_flow.text AS Payment, expenses.amount AS Amount, expenses.date AS Date FROM expenses INNER JOIN descriptions ON expenses.description_id = descriptions.id INNER JOIN from_to_flow ON expenses.from_to_flow_id = from_to_flow.id INNER JOIN users ON expenses.user_id = users.id INNER JOIN cash_flow ON expenses.cash_flow_id = cash_flow.id WHERE expenses.id = {insertedId}";
                                        DataTable dt = DB.GetDataTable();
                                        dgv_expense.DataSource = dt;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }                                     
                }
                catch(Exception ex) { MessageBox.Show(ex.ToString()); }
                validate.ControlClear(groupBox1);
            }
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            keycontrol.AllowOnlyNumbers(sender, e);
        }

        private void cbo_description_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.TriggerButtonClickOnRightArrow(sender, e, button2);
        }

        private void cbo_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            keycontrol.AllowOnlyLetters(sender, e);
        }

        private void cbo_from_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.TriggerButtonClickOnRightArrow(sender, e, button3);
        }

        private void cbo_type_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.TriggerButtonClickOnRightArrow(sender, e, button4);
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender, e, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Expense Title :";
            InvokeAddNew(title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = "To :";
            InvokeAddNew(title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string title = "Payment :";
            InvokeAddNew(title);
        }

        private void InvokeAddNew(string title)
        {
            frm_addnewdata addnewdata = new frm_addnewdata();
            addnewdata.ExpenseForm = this;
            addnewdata.labelName = title;
            addnewdata.ShowDialog();
        }

        private void dgv_expense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;

                DataGridViewCell currentCell = dgv_expense.CurrentCell;
                int currentRowIndex = currentCell.RowIndex;
                int currentColumnIndex = currentCell.ColumnIndex;

                if (currentRowIndex < dgv_expense.RowCount - 1)
                {
                    dgv_expense.CurrentCell = dgv_expense[currentColumnIndex, currentRowIndex + 1];
                }
                else
                {
                    dgv_expense.CurrentCell = dgv_expense[0, 0];
                }
            }
        }

        private void cbo_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            keycontrol.AllowOnlyLetters(sender, e);
        }
    }
}
