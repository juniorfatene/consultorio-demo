using ConsultorioDemo.Models.Entities;
using ConsultorioDemo.Repository.Interfaces;
using ConsultorioDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PacienteController : ControllerBase
	{
		private readonly IPacienteRepository _repository;

		public PacienteController(IPacienteRepository repository)
		{
			_repository = repository;

		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var pacientes = await _repository.GetPacientesAsync();
			return pacientes.Any()
				? Ok(pacientes)
				: BadRequest("Paciente não encontrado");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var paciente = await _repository.GetPacienteByIdAsync(id);
			return paciente != null
					? Ok(paciente)
					: BadRequest("Paciente não encontrado");
		}
	

	}
}
