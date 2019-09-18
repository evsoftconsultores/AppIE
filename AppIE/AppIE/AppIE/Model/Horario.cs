using System;
using System.Collections.Generic;
using System.Text;

namespace AppIE.Model
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public string NameHorario { get; set; }
        public List<Dia> Dias { get; set; }

    }

    public class Dia {
        public int IdDia { get; set; }
        public string NameDia { get; set; }
        public List<Curso> Cursos { get; set; }
    }

    public class HorarioData {

        public static Horario Horario { get; set; }

        static HorarioData()
        {
            Horario = new Horario();

            Horario = (new Horario
            {
                IdHorario = 1,
                NameHorario="5to Nivel Secundario - Aula B",
                Dias = new List<Dia>(){
                                        new Dia { IdDia = 1, NameDia = "Lunes",
                                            Cursos= new List<Curso>(){
                                                new Curso{ IdCurso=1,NameCurso="Matemática" },
                                                new Curso{ IdCurso=1,NameCurso="Comunicación" },
                                                new Curso{ IdCurso=1,NameCurso="Toturia" }
                                            }
                                        }
                                    }
            }); 
                                        
        }
    }
}
