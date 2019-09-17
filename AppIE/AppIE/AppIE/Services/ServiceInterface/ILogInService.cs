using AppIE.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppIE.Services.ServiceInterface
{
    public interface ILogInService
    {
        Task<User> LogIn(string UserName, string Password);
    }
}
