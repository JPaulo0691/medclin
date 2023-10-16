using MedClin.DTOs.MedicoDTOs.Request;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

		[ForeignKey("EspecialidadeId")]
		public int EspecialidadeId { get; set; }

		// Propriedade de navegação para a especialidade
		public virtual Especialidades Especialidade { get; set; }

		public Medico() { }

		public Medico(CadastrarMedicoRequest cadastrarMedico)
		{
			Nome = cadastrarMedico.Nome;
			Crm = cadastrarMedico.Crm;
			EspecialidadeId = cadastrarMedico.EspecialidadeId;
			Status = true;
		}

		public Medico(AtualizarStatusMedicoRequest atualizarStatusMedico)
		{
			Status = atualizarStatusMedico.Status;
		}        

    }
}
