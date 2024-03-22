using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class frm_income : Form
    {
        private frm_home homeForm;
        public frm_income(frm_home home)
        {
            InitializeComponent();
            homeForm = home;
        }
        DateTimePicker Dtpk;
        TextBox Txb;
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
        private void frm_income_Load(object sender, EventArgs e)
        {
            validate.ControlClear(groupBox1);
            DB.sql = "EXEC IncomeFormLoading;";
            SqlDataReader dr = DB.GetDataReader();
            while(dr.Read())
            {
                cbo_description.Items.Add(dr["description"].ToString());                
            }
            dr.NextResult();
            while(dr.Read())
            {
                cbo_from.Items.Add(dr["From"].ToString());
            }
            dr.NextResult();
            while (dr.Read())
            {
                cbo_type.Items.Add(dr["IncomeType"].ToString());
            }
            dr.NextResult();
            DB.sql = "EXEC GetIncome";
            DataTable dt = DB.GetDataTable();
            dgv_income.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_income.DataSource = null;
            pnl_search.Controls.Clear();
            if(comboBox1.SelectedIndex == 0)
            {
                DateTimePicker dtpk = new DateTimePicker();
                dtpk.Format = DateTimePickerFormat.Short;
                dtpk.Value = DateTime.Now;
                pnl_search.Controls.Add(dtpk);
                dtpk.Visible = true;
                Dtpk = dtpk;
                dtpk.ValueChanged += dtpk_ValueChanged;

            }
            else
            {
                TextBox tb = new TextBox();
                Txb = tb;
                tb.TextChanged += tb_TextChanged;
                tb.Size = pnl_search.Size;
                pnl_search.Controls.Add(tb);
            }
        }
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            dgv_income.DataSource = null;
            int year = Dtpk.Value.Year;
            int month = Dtpk.Value.Month;
            DB.sql = "EXEC GetIncomeByMonth @Year = '"+year+"',@Month = '"+month+"';";
            
            DataTable dt = DB.GetDataTable();
            dgv_income.DataSource = dt;
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            dgv_income.DataSource = null;
            string username = Txb.Text.Trim();
            DB.sql = "EXEC GetIncomeByUser @Username = '" + username + "';";
            DataTable dt = DB.GetDataTable();
            dgv_income.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_income.DataSource = null;
            bool messageShown = validate.TextCheck(groupBox1);
            if (!messageShown)
            {
                string description = cbo_description.SelectedItem?.ToString();
                string FromToFlow = cbo_from.SelectedItem?.ToString();
                string User = Program.name.ToString();
                string CashFlow = cbo_type.SelectedItem?.ToString();
                decimal Amount;
                if(Decimal.TryParse(txt_amount.Text,out Amount))
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
                try
                {
                    DB.sql = "EXEC AddNewIncome @Description = '" + description + "', @FromToFlow = '" + FromToFlow + "', @User = '" + User + "', " +
                             "@CashFlow = '" + CashFlow + "', @Amount = " + Amount + ", @Date = '" + formattedDate + "', @InsertedId = @InsertedId OUTPUT";
                    DialogResult result = MessageBox.Show("Are you sure want to add income? Added Incomes can't be delete next time.", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        string message = "New Income added successfully!";                   
                        DB.DoInsert(message,out insertedId);
                        homeForm.balanceRefresh();
                    }
                    
                    if (insertedId != -1)
                    {
                        DB.sql = "SELECT descriptions.description AS Description," +
                               "       from_to_flow.text AS [From]," +
                               "       users.name AS Name," +
                               "       cash_flow.text AS Payment," +
                               "       incomes.amount AS Amount," +
                               "       incomes.date AS Date" +
                               " FROM incomes" +
                               " INNER JOIN descriptions ON incomes.description_id = descriptions.id" +
                               " INNER JOIN from_to_flow ON incomes.from_to_flow_id = from_to_flow.id" +
                               " INNER JOIN users ON incomes.user_id = users.id" +
                               " INNER JOIN cash_flow ON incomes.cash_flow_id = cash_flow.id" +
                               " WHERE incomes.id = " + insertedId;
                        DataTable dt = DB.GetDataTable();
                        dgv_income.DataSource = dt;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            keycontrol.KeyDownEnterNextButtonClick(sender,e,button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Income Title :";
            InvokeAddNew(title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = "From :";
            InvokeAddNew(title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string title = "IncomeType :";
            InvokeAddNew(title);
        }
        private void InvokeAddNew(string title)
        {
            frm_addnewdata addnewdata = new frm_addnewdata();
            addnewdata.IncomeForm = this;
            addnewdata.labelName = title;
            addnewdata.ShowDialog();
        }

        private void dgv_income_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;

                DataGridViewCell currentCell = dgv_income.CurrentCell;
                int currentRowIndex = currentCell.RowIndex;
                int currentColumnIndex = currentCell.ColumnIndex;

                if (currentRowIndex < dgv_income.RowCount - 1)
                {
                    dgv_income.CurrentCell = dgv_income[currentColumnIndex, currentRowIndex + 1];
                }
                else
                {
                    dgv_income.CurrentCell = dgv_income[0, 0];
                }
            }
        }
    }
}
