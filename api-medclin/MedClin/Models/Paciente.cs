using MedClin.DTOs;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MedClin.Models
{
    public class Paciente
	{
		[Key]
		[Required]
		public int Id { get; set; }
		[Required(ErrorMessage = "Campo nome é obrigatório")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "CPF é obrigatório")]
		public string Cpf { get; set; }
		[Required(ErrorMessage = "Campo Endereço é Obrigatório")]	
		public Endereco Endereco { get; set; }
		[Required(ErrorMessage = "Campo contato é obrigatório")]
		public string Contato { get; set; }
		public bool Status { get; set; }	 

        public Paciente() {        
        }

        public Paciente(CadastrarPacienteDTO pacienteDTO)
        {
            Nome = pacienteDTO.Nome;
			Cpf = pacienteDTO.Cpf;
			Endereco = new Endereco(pacienteDTO);
			Contato = pacienteDTO.Contato;
			Status = true;
        }

		public Paciente(AtualizarPacienteDTO pacienteDTO)
		{
			Nome = pacienteDTO.Nome;
			Cpf = pacienteDTO.Cpf;
			Endereco = new Endereco(pacienteDTO);
			Contato = pacienteDTO.Contato;
			Status = true;
		}

        public Paciente(AtualizarStatusDTO atualizarStatus)
        {
            Status = atualizarStatus.Status;
        }


    }
}
