using Microsoft.AspNetCore.Mvc;
using GrupoGaGu.PonderadaBackend.Repository;
using System.Threading.Tasks;

namespace GrupoGaGu.PonderadaBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await _employeesRepository.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                // Log o erro ou retorne um erro apropriado para o cliente
                return StatusCode(500, "Erro interno do servidor");
            }
        }
    }
}
