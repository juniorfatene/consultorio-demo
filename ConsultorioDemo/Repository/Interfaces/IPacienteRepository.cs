using ConsultorioDemo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Repository.Interfaces
{
	public interface IPacienteRepository : IBaseRepository
	{
		Task<IEnumerable<Paciente>> GetPacientesAsync();

		Task<Paciente> GetPacienteByIdAsync(int id);
	}
}
