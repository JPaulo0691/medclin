using System.ComponentModel.DataAnnotations;

namespace MedClin.Models
{
	public class Especialidade
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Nome { get; set; }
		public List<Medico> Medicos { get; set; }
	}
}
