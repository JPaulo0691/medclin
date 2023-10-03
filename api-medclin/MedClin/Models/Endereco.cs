using MedClin.DTOs;
using MedClin.DTOs.MedicoDTOs.Request;

namespace MedClin.Models
{
    public class Endereco
	{
		public string Estado { get; set; }
		public string Municipio { get; set; }
		public string Bairro { get; set; }
		public string Rua { get; set; }
		public string Complemento { get; set; }
		public int Numero { get; set; }

		public Endereco() { }

        public Endereco(CadastrarPacienteDTO pacienteDTO)
		{
			Estado = pacienteDTO.Estado;
			Municipio = pacienteDTO.Municipio;
			Bairro = pacienteDTO.Bairro;
			Rua = pacienteDTO.Rua;
			Complemento = pacienteDTO.Complemento;
			Numero = pacienteDTO.Numero;
		}

		public Endereco(AtualizarPacienteDTO pacienteDTO)
		{
			Estado = pacienteDTO.Estado;
			Municipio = pacienteDTO.Municipio;
			Bairro = pacienteDTO.Bairro;
			Rua = pacienteDTO.Rua;
			Complemento = pacienteDTO.Complemento;
			Numero = pacienteDTO.Numero;
		}

	}
}