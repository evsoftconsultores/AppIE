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
        [DataMember(Name = "nromatricula")]
        public string NroMatricula { get; set; }
        [DataMember(Name = "condicion")]
        public string Condicion { get; set; }
    }

    public class UserData
    {
        public static IList<User> Users { get; private set; }

        static UserData()
        {
            Users = new List<User>();

            Users.Add(new User { IdUser = 1,UserName="GINCIO", Password="10101010",Nombre="GLORIA FELICITA", Apellidos="ZAPATA INCIO",NroMatricula="40904759", Condicion="Alumno" });
            Users.Add(new User { IdUser = 2, UserName = "EINCIO", Password = "04748826", Nombre = "ENRIQUE", Apellidos = "INCIO CHAPILLIQUEN", NroMatricula = "75868956", Condicion = "Desarrollador" });
            Users.Add(new User { IdUser = 3, UserName = "RJAUREGUI", Password = "12345678", Nombre = "LUIS RAFAEL", Apellidos = "JÁUREGUI DÍAZ", NroMatricula = "65235784", Condicion = "Docente" });
            Users.Add(new User { IdUser = 4, UserName = "WPAREDES", Password = "87654321", Nombre = "WELLINGTON ISAAC", Apellidos = "PAREDES PAULINI", NroMatricula = "52568945", Condicion = "Alumno" });
        }

    }
}
