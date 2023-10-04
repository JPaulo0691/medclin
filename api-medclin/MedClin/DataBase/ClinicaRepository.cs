using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	//public class ClinicaRepository : DbContext
	//{
	//	public ClinicaRepository(DbContextOptions<ClinicaRepository> options) : base(options) { }

	//	public DbSet<Clinica> Clinicas { get; set; }

	//	protected override void OnModelCreating(ModelBuilder modelBuilder)
	//	{
	//		modelBuilder.Entity<MedicoClinica>()
	//			.HasKey(mc => new { mc.MedicoId, mc.ClinicaId });

	//		modelBuilder.Entity<MedicoClinica>()
	//			.HasOne(mc => mc.Medico)
	//			.WithMany(m => m.MedicosClinicas)
	//			.HasForeignKey(mc => mc.MedicoId);

	//		modelBuilder.Entity<MedicoClinica>()
	//			.HasOne(mc => mc.Clinica)
	//			.WithMany(c => c.MedicosClinicas)
	//			.HasForeignKey(mc => mc.ClinicaId);

	//		modelBuilder.Entity<Clinica>(entity =>
	//		{
	//			entity.OwnsOne(c => c.Endereco, endereco =>
	//			{
	//				endereco.Property(e => e.Estado).HasColumnName("Estado").IsRequired();
	//				endereco.Property(e => e.Municipio).HasColumnName("Municipio").IsRequired();
	//				endereco.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();
	//				endereco.Property(e => e.Rua).HasColumnName("Rua").IsRequired();
	//				endereco.Property(e => e.Complemento).HasColumnName("Complemento").IsRequired();
	//				endereco.Property(e => e.Numero).HasColumnName("Numero").IsRequired();
	//			});

	//			// Outras propriedades da Clinica
	//			entity.Property(c => c.Nome).IsRequired();
	//			entity.Property(c => c.Cnpj).IsRequired();
	//			entity.Property(c => c.Contatos).IsRequired();
				
	//		});

	//		// Configurações adicionais, se necessário
	//	}
	//}
}
