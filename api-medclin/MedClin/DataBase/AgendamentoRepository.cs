using MedClin.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MedClin.DataBase
{
	//public class AgendamentoRepository: DbContext
	//{
	//	public AgendamentoRepository(DbContextOptions<AgendamentoRepository> options) : base(options) { }

	//	public DbSet<Agendamento> Agendamentos { get; set; }

	//	protected override void OnModelCreating(ModelBuilder modelBuilder)
	//	{
	//		// Configuração da tabela Agendamento
	//		modelBuilder.Entity<Agendamento>().ToTable("Agendamentos");

	//		// Relacionamento com Medico
	//		modelBuilder.Entity<Agendamento>()
	//			.HasOne(a => a.Medico)
	//			.WithMany(m => m.Agendamentos)
	//			.HasForeignKey(a => a.MedicoId)
	//			.OnDelete(DeleteBehavior.Restrict); // ou DeleteBehavior.Cascade, dependendo da sua lógica

	//		// Relacionamento com Paciente
	//		modelBuilder.Entity<Agendamento>()
	//			.HasOne(a => a.Paciente)
	//			.WithMany(p => p.Agendamentos)
	//			.HasForeignKey(a => a.PacienteId)
	//			.OnDelete(DeleteBehavior.Restrict);

	//		// Relacionamento com Clinica
	//		modelBuilder.Entity<Agendamento>()
	//			.HasOne(a => a.Clinica)
	//			.WithMany(c => c.Agendamentos)
	//			.HasForeignKey(a => a.ClinicaId)
	//			.OnDelete(DeleteBehavior.Restrict);

	//		// Outras configurações, se necessário

	//		base.OnModelCreating(modelBuilder);
	//	}
	//}
}
