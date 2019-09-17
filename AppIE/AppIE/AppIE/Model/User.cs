using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppIE.Model
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "iduser")]
        public int IdUser { get; set; }
        [DataMember(Name = "username")]
        public string UserName { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "apellidos")]
        public string Apellidos { get; set; }
    }

    public class UserData
    {
        public static IList<User> Users { get; private set; }

        static UserData()
        {
            Users = new List<User>();

            Users.Add(new User { IdUser = 1,UserName="GINCIO", Password="10101010",Nombre="GLORIA", Apellidos="ZAPATA INCIO" });
            Users.Add(new User { IdUser = 2, UserName = "EINCIO", Password = "04748826", Nombre = "ENRIQUE", Apellidos = "INCIO CHAPILLIQUEN" });
            Users.Add(new User { IdUser = 3, UserName = "DOCENTE", Password = "12345678", Nombre = "DOCENTE", Apellidos = "LICEO TRUJILLO" });
            Users.Add(new User { IdUser = 4, UserName = "AMIGO", Password = "87654321", Nombre = "AMIGO", Apellidos = "AMIGO DE GLORIA" });
        }

    }
}
