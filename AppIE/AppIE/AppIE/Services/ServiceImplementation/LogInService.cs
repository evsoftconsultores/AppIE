using AppIE.Model;
using AppIE.RestClient;
using AppIE.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppIE.Services.ServiceImplementation
{
    public class LogInService : ILogInService
    {
        public Task<User> LogIn(string UserName, string Password)
        {
            RestClient<User> _restClient = new RestClient<User>();
            return _restClient.LogIn(UserName, Password);
        }
    }
}
