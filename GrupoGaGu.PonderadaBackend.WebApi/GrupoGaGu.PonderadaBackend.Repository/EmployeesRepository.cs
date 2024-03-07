using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace GrupoGaGu.PonderadaBackend.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly string _dbConfig;

        public EmployeesRepository(string dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployees()
        {
            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                return await conn.QueryAsync<EmployeeModel>(@"
                      SELECT
                        n_pessoal as Npessoal
                       FROM empregados
                ");
            }
        }
    }
}
