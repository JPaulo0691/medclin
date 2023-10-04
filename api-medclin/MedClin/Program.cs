using MedClin.DataBase;
using MedClin.DTOs.MedicoDTOs.Request;
using MedClin.Models;
using MedClin.Services.Interface;
using MedClin.Services.ServicesImpl;
using MedClin.Validations;
using MedClin.Validations.Medicos;
using Microsoft.EntityFrameworkCore;

namespace MedClin
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var connectionString = builder.Configuration.GetConnectionString("MedClinConnection");

			builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

			//Injetando serviço Médico
			builder.Services.AddScoped<ICadastrarMedicoService, MedicoService>();
			builder.Services.AddScoped<IBuscarMedicoPorCrm, MedicoService>();
			builder.Services.AddScoped<IListarTodosOsMedicosDisponiveis, MedicoService>();
			builder.Services.AddScoped<IAtualizarStatusMedico, MedicoService>();

			builder.Services.AddScoped<IValidForm<CadastrarMedicoRequest>, ValidarCrmCadastrado>();

			//DataBase Conn
			builder.Services.AddDbContext<PacienteRepository>(opts => 
				opts.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));

			builder.Services.AddDbContext<MedicoRepository>(opts =>
				opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

			//builder.Services.AddDbContext<AgendamentoRepository>(opts =>
			//	opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

			//builder.Services.AddDbContext<ClinicaRepository>(opts =>
			//	opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

			builder.Services.AddDbContext<EspecialidadeRepository>(opts =>
				opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}