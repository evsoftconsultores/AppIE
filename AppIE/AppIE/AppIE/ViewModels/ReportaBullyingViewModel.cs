using AppIE.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppIE.ViewModels
{
    public class ReportaBullyingViewModel
    {
        public IList<TipoBullying> TipoBullyings { get { return TipoBullyingData.TipoBullyings; } }

        public IList<NivelAcademico> NivelAcademicos { get { return NivelAcademicoData.NivelAcademicos; } }


    }
}
