using System;
using System.Collections.Generic;
using System.Text;

namespace AppIE.Model
{
    public class Merito
    {
        public int IdMerito { get; set; }
        public string NameMerito { get; set; }
        //Merito tiene una lista de Detalles con su puntaje
        public List<DetalleMerito> DetalleMeritos { get; set; }
    }

    public class DetalleMerito
    {
        public int IdDetMerito { get; set; }
        public string Descr { get; set; }
        public int puntaje { get; set; }
    }

    public class MerecimientoAlumno
    {
        public int Id { get; set; }
        public string NroMatricula { get; set; }
        public string Fecha { get; set; }
        public Merito Merito { get; set; }
        public DetalleMerito DetalleMerito { get; set; }
    }

    public static class MerecimientoAlumnoData
    {
        public static List<MerecimientoAlumno> MerecimientoAlumnos { get; set; }

        static MerecimientoAlumnoData()
        {
            MerecimientoAlumnos = new List<MerecimientoAlumno>();

            MerecimientoAlumnos.Add(new MerecimientoAlumno { Id = 1, NroMatricula = "40904759", Fecha="18/09/2019", Merito = new Merito { IdMerito = 11, NameMerito = "Deméritos" }, DetalleMerito = new DetalleMerito { IdDetMerito = 101, Descr = "No trajo su libro de inglés.", puntaje = -8 } } );
            MerecimientoAlumnos.Add(new MerecimientoAlumno { Id = 2, NroMatricula = "40904759", Fecha="22/05/2019", Merito = new Merito { IdMerito = 10, NameMerito = "Mérito" }, DetalleMerito = new DetalleMerito { IdDetMerito = 205, Descr = "Ayuda a sus compañeros en clase.", puntaje = 10 }  });
            MerecimientoAlumnos.Add(new MerecimientoAlumno { Id = 3, NroMatricula = "40904759", Fecha="11/07/2019", Merito = new Merito { IdMerito = 11, NameMerito = "Deméritos" }, DetalleMerito = new DetalleMerito { IdDetMerito = 150, Descr = "No hizo limpieza de aula.", puntaje = -15 } });
        }
    }
}
