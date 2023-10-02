using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.DTOs.MedicoDTOs.Response;
using MedClin.Models;
using MedClin.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedClin.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MedicoController : ControllerBase
	{

		private ICadastrarMedicoService _cadastrarMedicoService;
		private IBuscarMedicoPorCrm _encontrarCRM;
		private IListarTodosOsMedicosDisponiveis  _listarTodosOsMedicosDisponiveis;
		private IAtualizarStatusMedico _atualizarStatusMedico;

		public MedicoController(ICadastrarMedicoService cadastrarMedicoService
			                      , IBuscarMedicoPorCrm buscarMedicoPorCrm
					, IListarTodosOsMedicosDisponiveis  listarTodosOsMedicosDisponiveis
					, IAtualizarStatusMedico atualizarStatusMedico)
		{
			_cadastrarMedicoService = cadastrarMedicoService;
			_encontrarCRM = buscarMedicoPorCrm;
			_listarTodosOsMedicosDisponiveis = listarTodosOsMedicosDisponiveis;
			_atualizarStatusMedico = atualizarStatusMedico;
		}

		[HttpPost]
		public IActionResult CadastrarMedico([FromBody] CadastrarMedicoRequest request)
		{

			var medico = _cadastrarMedicoService.CadastrarMedico(request);

			return CreatedAtAction(nameof(EncontrarMedicoPorCrm), new { crm = medico.Crm }, medico);
		}

		[HttpGet]
		public IActionResult ListarMedicosDisponiveis()
		{
			var listarMedicos = _listarTodosOsMedicosDisponiveis.ListarTodosOsMedicosDisponiveis();

			return Ok(listarMedicos);
		}

		[HttpGet("{crm}")]
		public IActionResult EncontrarMedicoPorCrm(string crm)
		{
			var medico = _encontrarCRM.EncontrarMedicoPorCrm(crm);

			if(medico == null)
			{
				return NotFound($"O médico com o Crm de nr.{medico.Crm}, não foi encontrado.");
			}

			return Ok(new CadastrarMedicoResponse(medico));
		}

		[HttpPut("{crm}")]
		public IActionResult AtualizarStatusDeAtividade(string crm, [FromBody] AtualizarStatusMedicoRequest status)
		{
			Medico medico = _atualizarStatusMedico.alterarStatus(crm, status);

			if (medico == null)
				return NotFound($"O crm de nr.{crm}, não foi encontrado");

			return Ok(new AtualizarStatusMedicoResponse(medico));
		}
	}
}
