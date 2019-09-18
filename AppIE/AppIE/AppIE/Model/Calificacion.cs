using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppIE.Model
{
    public class Calificacion
    {
        public int IdNota { get; set; }
        public int Nota1 { get; set; }
    }

    [DataContract]
    public class Competencias
    {
        [DataMember(Name = "idcompetencia")]
        public int IdCompetencia { get; set; }
        [DataMember(Name = "descr")]
        public string Descr { get; set; }
        [DataMember(Name = "promedio")]
        public int Promedio { get; set; }
    }
}