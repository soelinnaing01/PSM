using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceManager
{
    public partial class frm_saving : Form
    {
        frm_home homeForm;
        TextBox Txb;
        public frm_saving(frm_home home)
        {
            InitializeComponent();
            this.homeForm = home;
        }

        private void frm_saving_Load(object sender, EventArgs e)
        {
            
            string username = Program.username;
            rdo_saving.Checked = true;
            DB.sql = "EXEC SavingLoad @username='"+username+"'";
            DataSet ds = DB.GetDataSet();
            dgv_saving.DataSource = ds.Tables[0];
            if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0 && ds.Tables[1].Rows[0][0] != DBNull.Value)
            {
                lbl_totalamount.Text = ds.Tables[1].Rows[0][0].ToString() + "-MMK";
            }
            else
            {
                lbl_totalamount.Text = "0.00-MMK";
            }

        }
        private void GetTotalSaving()
        {
            DB.sql = "EXEC GetTotalSaving";
            DataTable dt = DB.GetDataTable();
            lbl_totalamount.Text = dt.Rows[0][0].ToString()+"-MMK";
        }
        private void Txb_TextChanged(Object sender, EventArgs e)
        {
            
        }

        private void rdo_saving_CheckedChanged(object sender, EventArgs e)
        {
            pnl_search.Controls.Clear();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "ByYear", "Months Of This Year" });
        }

        private void rdo_withdraw_CheckedChanged(object sender, EventArgs e)
        {
            pnl_search.Controls.Clear();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "By Name", "ByYear", "Month Of This Year" });
        }
        int condition;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_saving.DataSource = null;
            pnl_search.Controls.Clear();
            TextBox txb = new TextBox();
            Txb = txb;
            txb.TextChanged += tb_TextChanged;
            pnl_search.Controls.Add(txb);
            txb.Size = pnl_search.Size;
            txb.KeyPress -= keycontrol.AllowOnlyLetters;
            txb.KeyPress -= keycontrol.AllowOnlyNumbers;
            if(rdo_saving.Checked ==true)
            {
                if(comboBox1.SelectedIndex ==0)
                {
                    txb.KeyPress += keycontrol.AllowOnlyNumbers;
                    condition = 1;
                }
                else
                {
                    txb.KeyPress += keycontrol.AllowOnlyLetters;
                    condition = 2;
                }
            };
            if (rdo_withdraw.Checked == true)
            {
                if(comboBox1.SelectedIndex ==0)
                {
                    txb.KeyPress += keycontrol.AllowOnlyLetters;
                    condition = 3;
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    txb.KeyPress += keycontrol.AllowOnlyNumbers;
                    condition = 4;
                }
                else
                {
                    txb.KeyPress += keycontrol.AllowOnlyLetters;
                    condition = 5;
                }
            }
        }

        private void btn_addsaving_Click(object sender, EventArgs e)
        {
            bool messageShown = validate.TextCheck(groupBox1);
            if (messageShown)
                return;
            dgv_saving.DataSource = null;
            string username = Program.username;
            DateTime Date = dtpk_saving.Value;
            string formattedDate = Date.ToString("yyyy-MM-dd");
            Decimal amount = Decimal.Parse(txt_amount.Text);
            int InsertedId;
            int StatusCode =-1;
            try
            {
                DB.sql = "EXEC AddNewSaving @Username = '"+username+"',@Amount = '"+amount+"',@SavingMonth = '"+formattedDate+"',@StatusCode = @StatusCode OUTPUT,@InsertedId = @InsertedId OUTPUT";
                DB.DoInsertSaving(out StatusCode, out InsertedId);
                if (StatusCode == 0)
                {
                    MessageBox.Show("New Saving Added successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DB.sql = "EXEC GetSavingByInsertedID @InsertedId = '" + InsertedId + "'";
                    DataTable dt = DB.GetDataTable();
                    dgv_saving.DataSource = dt;
                    GetTotalSaving();
                    homeForm.balanceRefresh();
                }
                else if (StatusCode == 2)
                {
                    MessageBox.Show("Saving amount execeed your balance amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                validate.ControlClear(groupBox1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            dgv_saving.DataSource = null;        
            switch (condition)
            {
                case 1:
                    int year;
                    string yearPattern = null;
                    if(int.TryParse(Txb.Text.Trim(),out year))
                    {
                        yearPattern = year.ToString();
                        DB.sql = "EXEC GetSavingByYearly @yearPattern =" + yearPattern;
                    }
                    
                    break;
                case 2:
                    string month;
                    if(!string.IsNullOrEmpty(Txb.Text.Trim()))
                    {
                        month = Txb.Text.Trim();
                        DB.sql = "EXEC GetSavingByMonthsOfCurrentYear @monthName =" + month;
                    }                  
                    break;
                case 3:
                    string name;
                    if(!string.IsNullOrEmpty(Txb.Text.Trim()))
                    {
                        name = Txb.Text.Trim();
                        DB.sql = "EXEC GetwithdrawSavingByUser @Name =" + name;
                    }
                    break;
                case 4:
                    int withdrawYear=0;
                    string withdrawyearPattern=null;
                    if(int.TryParse(Txb.Text.Trim(),out withdrawYear))
                    {
                        withdrawyearPattern = withdrawYear.ToString();
                        DB.sql = "EXEC GetwithdrawByYearly @withdrawyearPattern=" + withdrawyearPattern;
                    }
                    break;
                case 5:
                    string withdrawMonth;
                    if(!string.IsNullOrEmpty(Txb.Text.Trim()))
                    {
                        withdrawMonth = Txb.Text.Trim();
                        DB.sql = "EXEC GetWithdrawByCurrentYear @withdrawMonth="+withdrawMonth;
                    }
                break;
                default:
                    throw new ArgumentException("Invalid value of condition");
                                  
            }
            DataTable dt = DB.GetDataTable();
            dgv_saving.DataSource = dt;
        }

        private void btn_AddWithdrawal_Click(object sender, EventArgs e)
        {
            bool showMessage = validate.TextCheck(groupBox2);
            if(showMessage)
            {
                return;
            }
            int InsertedId = -1;
            string name = Program.name.ToString();
            decimal amount;
            if (!Decimal.TryParse(txt_withdrawAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DB.sql = "EXEC AddNewWithdrawSaving @userName = '" + name + "', @Amount = " + amount.ToString("F2", CultureInfo.InvariantCulture) + ", @InsertedId = @InsertedId OUTPUT";
            string message = "Your withdrawal was successful!";

            DB.DoInsert(message, out InsertedId);
            if(InsertedId !=-1)
            {
                dgv_saving.DataSource = null;
                DB.sql = "SELECT users.name AS [User], date AS WithdrawDate, amount AS Amount FROM withdraw_saving\r\n\tINNER JOIN users ON withdraw_saving.user_id = users.id\r\n\tWHERE withdraw_saving.id ="+InsertedId;
                DataTable dt = DB.GetDataTable();
                if(dt.Rows.Count > 0)
                {
                    dgv_saving.DataSource = dt;
                }
                PopulateDataGridView();
                validate.ControlClear(groupBox2);
                GetTotalSaving();
                homeForm.balanceRefresh();
            }

        }

        private void dgv_saving_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;

                DataGridViewCell currentCell = dgv_saving.CurrentCell;
                int currentRowIndex = currentCell.RowIndex;
                int currentColumnIndex = currentCell.ColumnIndex;

                if (currentRowIndex < dgv_saving.RowCount - 1)
                {
                    dgv_saving.CurrentCell = dgv_saving[currentColumnIndex, currentRowIndex + 1];
                }
                else
                {
                    dgv_saving.CurrentCell = dgv_saving[0, 0];
                }
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender,e,btn_addsaving);
        }

        private void txt_withdrawAmount_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender, e, btn_AddWithdrawal);
        }
        private void PopulateDataGridView()
        {
            foreach (DataGridViewRow row in dgv_saving.Rows)
            {
                DataGridViewCell amountCell = row.Cells[2];
                if (amountCell.Value != null && decimal.TryParse(amountCell.Value.ToString(), out decimal amount))
                {
                    DataGridViewCell dateTypeCell = row.Cells[1];
                    if (dateTypeCell.OwningColumn.HeaderText == "WithdrawDate")
                    {
                        amountCell.Value = "-" + Math.Abs(amount).ToString();
                    }
                }
            }
        }

    }
}
