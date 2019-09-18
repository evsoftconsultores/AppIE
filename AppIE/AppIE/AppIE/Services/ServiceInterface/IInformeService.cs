using AppIE.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppIE.Services.ServiceInterface
{
    public interface IInformeService
    {
        Task<Docente> GetCalificativos();
    }
}
