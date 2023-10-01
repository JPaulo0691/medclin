using MedClin.Models;
using System.ComponentModel.DataAnnotations;

namespace MedClin.DTOs
{
	public class CadastrarPacienteDTO
	{
		[Required(ErrorMessage = "Campo nome é obrigatório")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "CPF é obrigatório")]
		public string Cpf { get; set; }
		[Required(ErrorMessage = "Campo Estado é Obrigatório")]
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
		[Required]
		public string Contato { get; set; }
	}
}
