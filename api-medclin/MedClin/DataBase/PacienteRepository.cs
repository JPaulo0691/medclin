using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	public class PacienteRepository : DbContext
	{
		public PacienteRepository(DbContextOptions<PacienteRepository> opts) : base(opts) { }

		public DbSet<Paciente> Paciente { get; set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Paciente>(entity =>
			{
				entity.OwnsOne(p => p.Endereco, endereco =>
				{
					endereco.Property(e => e.Estado).HasColumnName("Estado").IsRequired();
					endereco.Property(e => e.Municipio).HasColumnName("Municipio").IsRequired();
					endereco.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();
					endereco.Property(e => e.Rua).HasColumnName("Rua").IsRequired();
					endereco.Property(e => e.Complemento).HasColumnName("Complemento").IsRequired();
					endereco.Property(e => e.Numero).HasColumnName("Numero").IsRequired();
				});			
			
			});
		}


	}
}
