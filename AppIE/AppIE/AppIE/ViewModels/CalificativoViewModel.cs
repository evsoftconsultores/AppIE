using AppIE.Model;
using AppIE.Services.ServiceImplementation;
using AppIE.Services.ServiceInterface;
using AppIE.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppIE.ViewModels
{
    public class CalificativoViewModel: BaseViewModel
    {
        private IInformeService _informeService;

        //public IList<Docente> Docentes { get { return DocenteData.Docentes; } }

        private IList<Docente> docentes;

        public IList<Docente> Docentes
        {
            get { return DocenteData.Docentes; }
            set
            {
                docentes = value;
                RaisePropertyChanged();
            }
        }

        private List<Curso> cursos;

        public List<Curso> Cursos
        {
            get { return cursos; }
            set {
                cursos = value;
                RaisePropertyChanged();
            }
        }

        private List<Competencias> competencias;

        public List<Competencias> Competencias
        {
            get { return competencias; }
            set {
                    competencias = value;
                    RaisePropertyChanged();
            }
        }

        private string correoE;

        public string CorreoE
        {
            get { return correoE; }
            set { correoE = value;
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
            set {
                if (selectedCurso != value)
                {
                    selectedCurso = value;
                    RaisePropertyChanged();
                }
            }
        }


        /*private ObservableCollection<Docente> docentes;

        public ObservableCollection<Docente> _Docentes 
        {
            get { return docentes; }
            set {
                docentes = value;
                RaisePropertyChanged();
            }
        }*/


        public ICommand SelectedDocenteChanged { get; private set; }
        public ICommand SelectedCursoChanged { get; private set; }

        public CalificativoViewModel()
        {
            try
            {
                IsBusy = true;
                _informeService = new InformeService();

                //Docentes = _informeService.GetCalificativos();

                SelectedDocenteChanged = new Command(LoadCursoDocente);
                SelectedCursoChanged = new Command(LoadCompetencias);

                IsBusy = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void LoadCursoDocente()
        {
            try
            {
                Cursos = new List<Curso>();
                Cursos = SelectedDocente.Cursos;
                CorreoE = SelectedDocente.Email;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            //await Application.Current.MainPage.DisplayAlert("Picker", "Picker changed", "OK");
        }

        void LoadCompetencias()
        {
            try
            {
                //Competencias = new List<Competencias>();
                if (SelectedCurso != null)
                {
                    Competencias= SelectedCurso.Competencias;
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
