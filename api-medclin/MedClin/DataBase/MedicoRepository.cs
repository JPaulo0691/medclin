using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	public class MedicoRepository : DbContext
	{
		public MedicoRepository(DbContextOptions<MedicoRepository> opts) : base(opts) { }

		public DbSet<Medico> Medicos { get; set; }					

	}
}
