using AppIE.Model;
using AppIE.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppIE.ViewModels
{
    public class ReportaBullyingViewModel: BaseViewModel
    {
        public IList<TipoBullying> TipoBullyings { get { return TipoBullyingData.TipoBullyings; } }

        public IList<NivelAcademico> NivelAcademicos { get { return NivelAcademicoData.NivelAcademicos; } }

        public Command ReportarCommand => new Command(ReportarBullying);

        private string txtAgresor;

        public string TxtAgresor
        {
            get { return txtAgresor; }
            set { txtAgresor = value;
                RaisePropertyChanged();
            }
        }

        private string txtDetalle;

        public string TxtDetalle
        {
            get { return txtDetalle; }
            set { txtDetalle = value;
                RaisePropertyChanged();
            }
        }


        private TipoBullying selectedTipoBullying;

        public TipoBullying SelectedTipoBullying
        {
            get { return selectedTipoBullying; }
            set {
                if(selectedTipoBullying != value) {
                    selectedTipoBullying = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        private NivelAcademico selectedNivelAcademico;

        public NivelAcademico SelectedNivelAcademico
        {
            get { return selectedNivelAcademico; }
            set {
                if (selectedNivelAcademico != value)
                {
                    selectedNivelAcademico = value;
                    RaisePropertyChanged();
                }
            }
        }


        public ReportaBullyingViewModel()
        {

        }

        async void ReportarBullying()
        {
            if (Validacion())
            {
                var result = await Application.Current.MainPage.DisplayAlert("Confirmación", "¿Desea reportar alerta de Bullying?", "Si", "No");

                if (result) {
                    TxtAgresor = null;
                    TxtDetalle = null;
                    await Application.Current.MainPage.DisplayAlert("Mensaje", "Alerta ha sido enviada!", "Aceptar");
                }
            }
            
        }

        bool Validacion() {

            if (SelectedTipoBullying == null)
            {
                Application.Current.MainPage.DisplayAlert("Validación", "Seleccione Tipo de Bullying.", "Aceptar");
                return false;
            }

            if (SelectedNivelAcademico == null)
            {
                Application.Current.MainPage.DisplayAlert("Validación", "Seleccione Nivel Academico.", "Aceptar");
                return false;
            }

            if (string.IsNullOrEmpty(TxtDetalle))
            {
                Application.Current.MainPage.DisplayAlert("Validación", "Debe expecificar el detalle del caso a reportar.", "Aceptar");
                return false;
            }

            return true;
        }

    }
}
