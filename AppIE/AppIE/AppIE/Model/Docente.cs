using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppIE.Model
{
    [DataContract]
    public class Docente
    {
        [DataMember(Name = "iddocente")]
        public int IdDocente { get; set; }
        [DataMember(Name = "apellido")]
        public string Apellido { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "cursos")]
        public List<Curso> Cursos { get; set; }
        [DataMember(Name = "fullnamedocente")]
        public string FullNameDocente { get { return this.Apellido + ", " + this.Nombre; } }

        /*public Docente()
        {
            this.FullNameDocente = this.Apellido + ", " + this.Nombre; 
        }*/
    }

    public class DocenteData
    {
        public static IList<Docente> Docentes { get; private set; }

        static DocenteData(){
            Docentes = new List<Docente>();

            Docentes.Add(new Docente 
            { 
                IdDocente = 101, 
                Apellido = "CHAPILLIQUEN ALBAN", 
                Nombre = "FELICITA", 
                Email="fchapilliquen@liceotru.com.pe",
                Cursos = new List<Curso>() { new Curso { IdCurso = 201, NameCurso = "MATEMATICA",
                                                            Competencias =new List<Competencias>(){
                                                                        new Competencias { IdCompetencia=306,Descr="Resuelve problemas de cantidad.",Promedio=15},
                                                                        new Competencias { IdCompetencia=307,Descr="Resuleve problemas de regularidad, equivalencia y cambio.",Promedio=14},
                                                                        new Competencias { IdCompetencia=308,Descr="Resuleve problemas de forma, movimiento y localización.",Promedio=12},
                                                                        new Competencias { IdCompetencia=309,Descr="Resuleve problemas de gestión de datos y incertidumbre.",Promedio=13}
                                                                                        }
                                                        },
                                             new Curso { IdCurso = 202, NameCurso = "COMUNICACIÓN" ,
                                                             Competencias =new List<Competencias>(){
                                                                 new Competencias { IdCompetencia=310,Descr="Se comunica oralmente en su lengua materna.",Promedio=17},
                                                                 new Competencias { IdCompetencia=311,Descr="Lee disvesos texto escritos en su lengua materna.",Promedio=16},
                                                                 new Competencias { IdCompetencia=312,Descr="Escribe diversos textos en su lengua materna.",Promedio=18}
                                                             }
                                             },
                                             new Curso { IdCurso = 203, NameCurso = "PERSONAL SOCIAL",
                                                             Competencias =new List<Competencias>(){
                                                                 new Competencias { IdCompetencia=313,Descr="Construye su identidad.",Promedio=14},
                                                                 new Competencias { IdCompetencia=314,Descr="Convive y participa democraticamente en la busqueda del bién común.",Promedio=18},
                                                                 new Competencias { IdCompetencia=315,Descr="Construye interpretaciones historicas.",Promedio=17},
                                                                 new Competencias { IdCompetencia=316,Descr="Gestiona responsablemente el espacio y el ambiente.",Promedio=12}
                                                             }
                                             },
                                            }  
                                      });

            Docentes.Add(new Docente
            {
                IdDocente = 102,
                Apellido = "CARDENAS ALVAREZ",
                Nombre = "LAIN",
                Email = "lcardenas@liceotru.com.pe",
                Cursos = new List<Curso>() { new Curso { IdCurso = 204, NameCurso = "RELIGIÓN",
                                                            Competencias =new List<Competencias>(){
                                                                new Competencias { IdCompetencia=301,Descr="Construye su identidad como persona humana, amada por Dios.",Promedio=15},
                                                                new Competencias { IdCompetencia=302,Descr="Asume su experiencia del encuentro personal y comunitario con Dios.",Promedio=18}
                                                                                }
                                                        },
                                             new Curso { IdCurso = 205, NameCurso = "CIENCIA Y AMBIENTE",
                                                             Competencias =new List<Competencias>(){
                                                                 new Competencias { IdCompetencia=303,Descr="Indaga sobre metodos cientificos para construir sus conocimientos.",Promedio=14},
                                                                 new Competencias { IdCompetencia=304,Descr="Explica el mundo fisico basandose en conocimientos sobre los seres vivos y materias.",Promedio=12},
                                                                 new Competencias { IdCompetencia=305,Descr="Diseña y construye soluciones tecnologicas para resolver problemas de su entorno.",Promedio=16}
                                                             }
                                             }
                                            }
            });

            Docentes.Add(new Docente
            {
                IdDocente = 103,
                Apellido = "ZAMORA SANZ",
                Nombre = "CESAR CARLOS",
                Email = "czamora@liceotru.com.pe",
                Cursos = new List<Curso>() { new Curso { IdCurso = 206, NameCurso = "COMPUTACIÓN",
                                                            Competencias=new List<Competencias>(){
                                                                new Competencias { IdCompetencia=317,Descr="Se desenvuelve el entornos virtuales generados por la TIC.",Promedio=16},
                                                                new Competencias { IdCompetencia=318,Descr="Gestiona su aprendizaje de manera autonoma.",Promedio=14}
                                                            }
                                                        }
                                            }
            });


        }
    }
}
