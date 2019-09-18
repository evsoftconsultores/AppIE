using AppIE.Model;
using AppIE.RestClient;
using AppIE.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppIE.Services.ServiceImplementation
{
    public class InformeService : IInformeService
    {
        public async Task<Docente> GetCalificativos()
        {
            RestClient<Docente> restClient = new RestClient<Docente>();
            return await restClient.GetCalificativos();
        }
    }

}
