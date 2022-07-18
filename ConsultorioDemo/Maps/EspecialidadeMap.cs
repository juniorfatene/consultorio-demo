using ConsultorioDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Maps
{
	public class EspecialidadeMap : BaseMap<Especialidade>
	{
		public EspecialidadeMap() : base("tb_especialidade")
		{}

		public override void Configure(EntityTypeBuilder<Especialidade> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.nome).HasColumnName("nome").IsRequired();
			builder.Property(x => x.Ativa).HasColumnName("ativa");

		}
	}

	
}
