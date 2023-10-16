using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs.EspecialidadeDTOs.Request
{
	public class CadastrarEspecialidadeRequest
	{
		[Required]
		public string Nome { get; set; }
	}
}
