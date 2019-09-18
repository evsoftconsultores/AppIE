using AppIE.Model;
using AppIE.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppIE.ViewModels
{
    public class ComunicadoViewModel: BaseViewModel
    {
        public List<Comunicado> Comunicados { get { return ComunicadoData.Comunicados; } }

    }
}
