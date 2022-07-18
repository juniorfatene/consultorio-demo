using ConsultorioDemo.Context;
using ConsultorioDemo.Models.Entities;
using ConsultorioDemo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Repository
{
	public class PacienteRepostory : BaseRepository, IPacienteRepository
	{
		private readonly ConsultorioContext _context;
		public PacienteRepostory(ConsultorioContext context) : base(context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Paciente>> GetPacientesAsync()
		{
			return await _context.Pacientes.Include(x=>x.Consultas).ToListAsync();
		}

		public async Task<Paciente> GetPacienteByIdAsync(int id)
		{
			return await _context.Pacientes.Include(x => x.Consultas).Where(x=>x.Id == id).FirstOrDefaultAsync();
		}
	}
}
