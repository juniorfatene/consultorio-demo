using ConsultorioDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultorioDemo.Maps
{
	public class ProfissionalMap : BaseMap<Profissional>
	{
		public ProfissionalMap() : base("tb_profissional")
		{}

		public override void Configure(EntityTypeBuilder<Profissional> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
			builder.Property(x => x.Ativo).HasColumnName("ativo");

			builder.HasMany(x => x.Especialidades)
				.WithMany(x => x.Profissionais)
				.UsingEntity<ProfissionalEspecialidade>(
					x => x.HasOne(x => x.Especialidade).WithMany().HasForeignKey(x => x.EspecialidadeId),
					x => x.HasOne(x => x.Profissionais).WithMany().HasForeignKey(x => x.ProfissionalId),
					x =>
					{
						x.ToTable("tb_profissional_especialidade");

						x.Property(p => p.EspecialidadeId).HasColumnName("id_especialidade").IsRequired();
						x.Property(p => p.ProfissionalId).HasColumnName("id_profissional").IsRequired();

					}
				);
		}
	}
}
