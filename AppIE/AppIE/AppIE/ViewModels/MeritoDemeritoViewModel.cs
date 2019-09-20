using AppIE.Model;
using AppIE.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppIE.ViewModels
{
    public class MeritoDemeritoViewModel: BaseViewModel
    {
        //public List<MerecimientoAlumno> MerecimientoAlumnos { get { return MerecimientoAlumnoData.MerecimientoAlumnos; } }

        private List<MerecimientoAlumno> merecimientoAlumnos;

        public List<MerecimientoAlumno> MerecimientoAlumnos
        {
            get { return merecimientoAlumnos; }
            set { merecimientoAlumnos = value;
                RaisePropertyChanged();
            }
        }


        public MeritoDemeritoViewModel()
        {
            MerecimientoAlumnos = MerecimientoAlumnoData.MerecimientoAlumnos;
            //string descr = MerecimientoAlumnos[0].DetalleMerito.Descr;
        }
    }
}
