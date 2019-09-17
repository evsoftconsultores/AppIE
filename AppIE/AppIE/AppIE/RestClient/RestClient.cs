using AppIE.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIE.RestClient
{
    public class RestClient<T>
    {
        #region LogIn
        public async Task<T> LogIn(string UserName, string Password)
        {
            IList<User> Users = UserData.Users;

            var result = Users.Where(u => u.UserName.ToUpper().Equals(UserName.ToUpper()) && u.Password.ToUpper().Equals(Password.ToUpper())).FirstOrDefault();

            if (result != null)
                //result = JsonConvert.SerializeObject(result.ToString());
                return (T)Convert.ChangeType(result, typeof(T));
            else
                return default(T);
        }
        #endregion
    }
}
