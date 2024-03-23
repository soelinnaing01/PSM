using PersonalFinanceManager.Dtos.Login;
using PersonalFinanceManager.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Services.Features.Login
{
    public class LoginService
    {
        private readonly DapperService _dapperService;

        public LoginService()
        {
            _dapperService = new DapperService();
        }

        public LoginModel Login(string username, string password)
        {
            var item = _dapperService.QueryStoredProcedure<LoginModel>(SqlQuery.LoginQuery.Login, new
            {
                username = username,
                password = password
            });
            return item.FirstOrDefault();
        }
    }
}
