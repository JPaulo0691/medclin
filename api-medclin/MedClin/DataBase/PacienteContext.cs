using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	public class PacienteContext : DbContext
	{
		public PacienteContext(DbContextOptions<PacienteContext> opts) : base(opts) { }

		public DbSet<Paciente> Paciente { get; set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Paciente>(entity =>
			{
				entity.OwnsOne(adress => adress.Endereco, endereco =>
				{
					endereco.Property(adress => adress.Estado).IsRequired();
					endereco.Property(adress => adress.Municipio).IsRequired();
					endereco.Property(adress => adress.Bairro).IsRequired();
					endereco.Property(adress => adress.Rua).IsRequired();
					endereco.Property(adress => adress.Complemento).IsRequired();
					endereco.Property(adress => adress.Numero).IsRequired();

				});
			});
		}
	}
}
