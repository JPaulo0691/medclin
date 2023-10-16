using MedClin.Models;
using Microsoft.EntityFrameworkCore;

namespace MedClin.DataBase
{
	public class EspecialidadeRepository : DbContext
	{
		public EspecialidadeRepository(DbContextOptions<EspecialidadeRepository> options) : base(options) { }

		public DbSet<Especialidades> Especialidades { get; set; }
	}
}
