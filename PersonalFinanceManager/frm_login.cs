using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalFinanceManager
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            DB.sql = "EXEC LoadUsers";
            DataSet userDataSet = DB.LoadUsers();
            if (userDataSet.Tables.Count > 0)
            {
                List<string> usernames = new List<string>();
                foreach (DataRow row in userDataSet.Tables[0].Rows)
                {
                    usernames.Add(row[0].ToString());
                }
                cbo_username.DataSource = usernames;
                cbo_username.SelectedItem = null;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = cbo_username.SelectedItem.ToString();
            string password = txt_password.Text.ToString();
            DB.sql = "EXEC Login @username = '" + username + "',@password = '" + password + "';";
            DataTable dt = DB.Login(username, password);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Program.name = row["name"].ToString();
                Program.username = row["username"].ToString();

                this.Hide();

                frm_home home = new frm_home();
                home.ShowDialog();
            }
            else
            {
                Alert.ErrorMessage("Incorrect! Your entered password wasn't found!");
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextButtonClick(sender, e, btn_login);
        }

        private void cbo_username_KeyDown(object sender, KeyEventArgs e)
        {
            keycontrol.KeyDownEnterNextTab(sender, e);
        }
    }
}
