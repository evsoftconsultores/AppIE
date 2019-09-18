using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using static AppIE.Model.BullyingData;

namespace AppIE.Model
{
    [DataContract]
    public class Bullying
    {
        [DataMember(Name = "idbullying")]
        public int IdBullying { get; set; }
        [DataMember(Name = "fechareporte")]
        public DateTime FechaReporte { get; set; }
        [DataMember(Name = "idtipob")]
        public int IdTipoB { get; set; }
        [DataMember(Name = "tipobullying")]
        public virtual TipoBullying TipoBullying { get; set; }
        [DataMember(Name = "idnivela")]
        public int IdNivelA { get; set; }
        [DataMember(Name = "nivelacademico")]
        public virtual NivelAcademico NivelAcademico { get; set; }
        [DataMember(Name = "descragresor")]
        public string DescrAgresor { get; set; }
        [DataMember(Name = "explicadetalle")]
        public string ExplicaDetalle { get; set; }
        [DataMember(Name = "emailrspta")]
        public string EmailRspta { get; set; }
        [DataMember(Name = "estado")]
        public int Estado { get; set; }
        [DataMember(Name = "tokendevice")]
        public string TokenDevice { get; set; }

    }

    public class BullyingData
    {
        public static List<Bullying> Bullyings { get; private set; }

        static BullyingData()
        {
            Bullyings = new List<Bullying>();
            Bullyings.Add(new Bullying { IdBullying = 1, FechaReporte = Convert.ToDateTime("08/09/2019 16:45:52"), IdTipoB = 1, IdNivelA = 2, DescrAgresor = "", ExplicaDetalle = "Alumno esta siendo agredido, 2do año seccion A.", EmailRspta = "enrique.incio@gmail.com", Estado = 0, TokenDevice = "ASAJKJASLLAJSASJASKAHSDGFEY" });
            Bullyings.Add(new Bullying { IdBullying = 2, FechaReporte = Convert.ToDateTime("07/08/2019 16:45:52"), IdTipoB = 2, IdNivelA = 2, DescrAgresor = "Alberto Campos", ExplicaDetalle = "Insulta a su compañero, 4to año seccion B.", EmailRspta = "", Estado = 0, TokenDevice = "ASAJKJASLLAJSASJASKAHSDGFEY" });
            Bullyings.Add(new Bullying { IdBullying = 3, FechaReporte = Convert.ToDateTime("22/07/2019 16:45:52"), IdTipoB = 3, IdNivelA = 3, DescrAgresor = "", ExplicaDetalle = "Alumno ofende a su compañero con palabras, 1er año seccion C.", EmailRspta = "ssalinas@gmail.com", Estado = 0, TokenDevice = "ASAJKJASLLAJSASJASKAHSDGFEY" });
            Bullyings.Add(new Bullying { IdBullying = 4, FechaReporte = Convert.ToDateTime("15/06/2019 16:45:52"), IdTipoB = 5, IdNivelA = 1, DescrAgresor = "Juana Perez", ExplicaDetalle = "En redes estan pasando algo que afecta al alumnado", EmailRspta = "mosquera@gmail.com", Estado = 0, TokenDevice = "ASAJKJASLLAJSASJASKAHSDGFEY" });
            Bullyings.Add(new Bullying { IdBullying = 5, FechaReporte = Convert.ToDateTime("08/05/2019 16:45:52"), IdTipoB = 6, IdNivelA = 3, DescrAgresor = "", ExplicaDetalle = "En facebook un un deprabado que capta a alumnas", EmailRspta = "", Estado = 0, TokenDevice = "ASAJKJASLLAJSASJASKAHSDGFEY" });
        }

    }

    [DataContract]
    public class TipoBullying
    {
        [DataMember(Name = "idtipob")]
        public int IdTipoB { get; set; }
        [DataMember(Name = "descr")]
        public string Descr { get; set; }
        [DataMember(Name = "comments")]
        public string Comments { get; set; }
    }

    public class TipoBullyingData
    {
        public static List<TipoBullying> TipoBullyings { get; private set; }

        static TipoBullyingData(){
            TipoBullyings = new List<TipoBullying>();

            TipoBullyings.Add(new TipoBullying { IdTipoB=1,Descr= "Físico",Comments= "Es el tipo de acoso más común, especialmente entre chicos. Incluye golpes, empujones e incluso palizas entre uno o varios agresores contra una sola víctima, En ocasiones, se produce también el robo o daño intencionado de las pertenencias de las víctimas." });
            TipoBullyings.Add(new TipoBullying { IdTipoB = 2, Descr = "Psicológico",Comments= "En este caso existe una persecución, intimidación, tiranía, chantaje, manipulación y amenazas al otro. Son acciones que dañan la autoestima de la víctima y fomentan su sensación de temor, con el problema añadido que son las más difíciles de detectar por parte de profesores o padres porque son formas de acoso o exclusión que se llevan a cabo a espaldas de cualquier persona que pueda advertir la situación." });
            TipoBullyings.Add(new TipoBullying { IdTipoB = 3, Descr = "Verbal",Comments= "Son acciones no corporales con la finalidad de discriminar, difundir chismes o rumores, realizar acciones de exclusión o bromas insultantes y repetidas del tipo poner apodos, insultar, amenazar, burlarse, reírse de los otros, generar rumores de carácter racista o sexual, etc. Es más utilizado por algunas chicas a medida que se van acercando a la adolescencia." });
            TipoBullyings.Add(new TipoBullying { IdTipoB = 4, Descr = "Sexual",Comments= "Se presenta un asedio, inducción o abuso sexual o referencias malintencionadas a partes íntimas del cuerpo de la víctima. Incluye el bullying homófobo, que es cuando el maltrato hace referencia a la orientación sexual de la víctima por motivos de homosexualidad real o imaginaria." });
            TipoBullyings.Add(new TipoBullying { IdTipoB = 5, Descr = "Social",Comments= "Pretende aislar al niño o joven del resto del grupo, ignorándolo, aislándolo y excluyéndolo del resto  Puede ser directo: excluir, no dejar participar a la víctima en actividades, sacarlos del grupo o indirecto: ignorar, tratar como un objeto, como si no existiera o hacer ver que no está ahí." });
            TipoBullyings.Add(new TipoBullying { IdTipoB = 6, Descr = "Cibernético",Comments= "Con la penetración de las nuevas tecnologías, cada vez es más frecuente este tipo de actos. Es un tipo de acoso muy grave y preocupante por la gran visibilidad y alcance que se logra de los actos de humillación contra la víctima y el anonimato en que pueden permanecer los acosadores. Los canales son muy variados: mensajes de texto en móviles, tablets y ordenadores,  páginas web y blogs,  juegos on line, correos electrónicos, chats, encuestas on line de mal gusto,  redes sociales, suplantación de identidad para poner mensajes, etc." });
        }
    }

    [DataContract]
    public class NivelAcademico
    {
        [DataMember(Name = "idnivela")]
        public int IdNivelA { get; set; }
        [DataMember(Name = "namenivel")]
        public string NameNivel { get; set; }
    }

    public class NivelAcademicoData
    {
        public static List<NivelAcademico> NivelAcademicos { get; private set; }

        static NivelAcademicoData()
        {
            NivelAcademicos = new List<NivelAcademico>();

            NivelAcademicos.Add(new NivelAcademico { IdNivelA=1,NameNivel="Inicial" });
            NivelAcademicos.Add(new NivelAcademico { IdNivelA = 2, NameNivel = "Primario" });
            NivelAcademicos.Add(new NivelAcademico { IdNivelA = 3, NameNivel = "Secundario" });
        }
    }

}
