using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs.MedicoDTOs.Request
{
	public class CadastrarMedicoRequest
	{
		public string Nome { get; set; }
		[Required]
		public string Crm { get; set; }
	
	}
}
