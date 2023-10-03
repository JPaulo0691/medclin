using MedClin.DTOs.MedicoDTOs.Request;
using System.ComponentModel.DataAnnotations;

namespace MedClin.Models
{
	public class Medico
	{
		[Key]
		[Required]
		public int Id { get; set; }
		[Required]
		public string Nome { get; set; }
		[Required]
		[StringLength(8, ErrorMessage = "O CRM só pode conter no máximo 8 dígitos")]
		public string Crm { get; set; }		
		public bool Status { get; set; }

		public Medico() { }

		public Medico(CadastrarMedicoRequest cadastrarMedico)
		{
			Nome = cadastrarMedico.Nome;
			Crm = cadastrarMedico.Crm;			
			Status = true;
		}

		public Medico(AtualizarStatusMedicoRequest atualizarStatusMedico)
		{
			Status = atualizarStatusMedico.Status;
		}        

    }
}
