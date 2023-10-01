using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs.MedicoDTOs.Request
{
	public class CadastrarMedicoRequest
	{
		public string Nome { get; set; }
		[Required]
		public string Crm { get; set; }
		[Required]
		public string Estado { get; set; }
		[Required]
		public string Municipio { get; set; }
		[Required]
		public string Bairro { get; set; }
		[Required]
		public string Rua { get; set; }
		[Required]
		public string Complemento { get; set; }
		[Required]
		public int Numero { get; set; }
	}
}
