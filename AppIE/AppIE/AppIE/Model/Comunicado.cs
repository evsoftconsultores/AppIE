using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppIE.Model
{
    [DataContract]
    public class Comunicado
    {
        [DataMember(Name = "idcomunica")]
        public int IdComunica { get; set; }
        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }
        [DataMember(Name = "fecha")]
        public string Fecha { get; set; }
        [DataMember(Name = "hora")]
        public string Hora { get; set; }
        [DataMember(Name = "docente")]
        public Docente Docente { get; set; }

    }

    public class ComunicadoData
    {
        public static List<Comunicado> Comunicados { get; set; }

        static ComunicadoData()
        {
            Comunicados = new List<Comunicado>();
            Comunicados.Add(new Comunicado { IdComunica = 1, Descripcion = "Primera asamblea general de padres de familia.", Fecha = "15/09/2019", Hora="04:00 p.m.", Docente = new Docente { IdDocente = 1, Apellido = "Alza Gomez", Nombre = "Alberto", Email = "aalva@liceotru.com.pe" } });
            Comunicados.Add(new Comunicado { IdComunica = 2, Descripcion = "Invitación a la Feria de Ciencias y Tecnología a nievl UGEL 03.", Fecha = "28/08/2019", Hora="08:00 a.m.", Docente = new Docente { IdDocente = 1, Apellido = "Cano Liñan", Nombre = "Juan Carlos", Email = "jcano@liceotru.com.pe" } });
        }
    }
}
