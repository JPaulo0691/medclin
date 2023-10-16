using MedClin.DTOs.EspecialidadeDTOs.Request;
using System.ComponentModel.DataAnnotations;

namespace MedClin.Models
{
	public class Especialidades
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Nome { get; set; }
		public virtual ICollection<Medico> Medicos { get; set; }

        public Especialidades()
        {
            
        }

		public Especialidades(Medico medico)
		{
			Nome = medico.Nome;
		}


		public Especialidades(CadastrarEspecialidadeRequest request)
		{
			Nome = request.Nome;
		}
    }
}
