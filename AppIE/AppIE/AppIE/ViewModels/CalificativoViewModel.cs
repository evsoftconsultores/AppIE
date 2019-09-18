using AppIE.Model;
using AppIE.Services.ServiceImplementation;
using AppIE.Services.ServiceInterface;
using AppIE.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIE.ViewModels
{
    public class CalificativoViewModel: BaseViewModel
    {
        private IInformeService _informeService;

        public IList<Docente> Docentes { get { return DocenteData.Docentes; } }

        private List<Curso> cursos;

        public List<Curso> Cursos
        {
            get { return cursos; }
            set { cursos = value;
                RaisePropertyChanged();
            }
        }

        private List<Competencias> competencias;

        public List<Competencias> Competencias
        {
            get { return competencias; }
            set { competencias = value;
                RaisePropertyChanged();
            }
        }

        private Docente selectedDocente;

        public Docente SelectedDocente
        {
            get { return selectedDocente; }
            set
            {
                if (selectedDocente != value)
                {
                    selectedDocente = value;
                    RaisePropertyChanged();
                }
            }
        }

        private Curso selectedCurso;

        public Curso SelectedCurso
        {
            get { return selectedCurso; }
            set { selectedCurso = value;
                RaisePropertyChanged();
            }
        }


        private ObservableCollection<Docente> docentes;

        public ObservableCollection<Docente> _Docentes 
        {
            get { return docentes; }
            set {
                docentes = value;
                RaisePropertyChanged();
            }
        }


        public ICommand SelectedDocenteChanged { get; private set; }
        public ICommand SelectedCursoChanged { get; private set; }

        public CalificativoViewModel()
        {
            IsBusy = true;
            _informeService = new InformeService();

            SelectedDocenteChanged = new Command(LoadCursoDocente);
            SelectedCursoChanged = new Command(LoadCompetencias);

            IsBusy = false;
        }

        private void LoadCursoDocente()
        {
            Cursos = new List<Curso>();
            Cursos = SelectedDocente.Cursos;
            //await Application.Current.MainPage.DisplayAlert("Picker", "Picker changed", "OK");
        }

        void LoadCompetencias()
        {

            Competencias = new List<Competencias>();
            Competencias= SelectedCurso.Competencias;
        }

    }
}
