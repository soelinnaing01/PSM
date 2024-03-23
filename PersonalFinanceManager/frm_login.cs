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
using PersonalFinanceManager.Services.Features.Login;

namespace PersonalFinanceManager
{
    public partial class frm_login : Form
    {
        private readonly LoginService _loginService;

        public frm_login()
        {
            InitializeComponent();
            _loginService = new LoginService();
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
            string username = cbo_username.SelectedItem == null ? cbo_username.Text : cbo_username.SelectedItem.ToString();
            string password = txt_password.Text.ToString();
            var user = _loginService.Login(username, password);
            if(user == null)
            {
                Alert.ErrorMessage("Incorrect! Your entered password wasn't found!");
                return;
            }

            Program.name = user.Name;
            Program.username = user.UserName;

            this.Hide();

            frm_dashboard home = new frm_dashboard();
            home.ShowDialog();

            //DB.sql = "EXEC Login @username = '" + username + "',@password = '" + password + "';";
            //DataTable dt = DB.Login(username, password);
            //if (dt.Rows.Count > 0)
            //{
            //    DataRow row = dt.Rows[0];
            //    Program.name = row["name"].ToString();
            //    Program.username = row["username"].ToString();

            //    this.Hide();

            //    frm_dashboard home = new frm_dashboard();
            //    home.ShowDialog();
            //}
            //else
            //{
            //    Alert.ErrorMessage("Incorrect! Your entered password wasn't found!");
            //}
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
