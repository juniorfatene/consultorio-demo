using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Models.Entities
{
	public class Especialidade: Base
	{
		public string nome { get; set; }
		public bool Ativa { get; set; }
		public List<Profissional> Profissionais { get; set; }
		public List<Consulta> Consultas { get; set; }
	}
}
