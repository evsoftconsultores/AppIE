 using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppIE.Model
{
    [DataContract]
    public class Curso
    {
        [DataMember(Name = "idcurso")]
        public int IdCurso { get; set; }
        [DataMember(Name = "namecurso")]
        public string NameCurso { get; set; }
        [DataMember(Name = "competencias")]
        public List<Competencias> Competencias { get; set; }
    }
}
