using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoGaGu.PonderadaBackend.Repository
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
      
    }
}
