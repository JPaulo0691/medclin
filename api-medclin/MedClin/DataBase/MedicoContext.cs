using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	public class MedicoContext : DbContext
	{

		public MedicoContext(DbContextOptions<MedicoContext> opts) : base(opts) { }

		public DbSet<Medico> Medicos { get; set; }

	}
}
