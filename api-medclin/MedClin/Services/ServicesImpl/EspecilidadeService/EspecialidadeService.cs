using MedClin.DataBase;
using MedClin.DTOs.EspecialidadeDTOs.Request;
using MedClin.Models;
using MedClin.Services.Interface.IEspecialidades;

namespace MedClin.Services.ServicesImpl.EspecilidadeService
{
	public class EspecialidadeService : ICadastrarEspecialidadeMedica, IEspecialidadePorId
	{
		private EspecialidadeRepository _especialidadeRepository;

		public EspecialidadeService(EspecialidadeRepository especialidadeRepository)
		{
			_especialidadeRepository = especialidadeRepository;
		}

		public Especialidades Cadastrar(CadastrarEspecialidadeRequest request)
		{
			Especialidades especialidade = new Especialidades(request);
			_especialidadeRepository.Especialidades.Add(especialidade);
			_especialidadeRepository.SaveChanges();

			return especialidade;
		}

		public Especialidades EncontrarEspecialidadePorId(int id)
		{
			return _especialidadeRepository.Especialidades.FirstOrDefault(especialidade => especialidade.Id == id);
		}
	}
}
