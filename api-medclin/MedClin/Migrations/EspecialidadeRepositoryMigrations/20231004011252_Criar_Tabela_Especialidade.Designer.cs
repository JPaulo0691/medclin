﻿// <auto-generated />
using MedClin.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedClin.Migrations.EspecialidadeRepositoryMigrations
{
    [DbContext(typeof(EspecialidadeRepository))]
    [Migration("20231004011252_Criar_Tabela_Especialidade")]
    partial class Criar_Tabela_Especialidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EspecialidadeMedico", b =>
                {
                    b.Property<int>("EspecialidadesId")
                        .HasColumnType("int");

                    b.Property<int>("MedicosId")
                        .HasColumnType("int");

                    b.HasKey("EspecialidadesId", "MedicosId");

                    b.HasIndex("MedicosId");

                    b.ToTable("EspecialidadeMedico");
                });

            modelBuilder.Entity("MedClin.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("MedClin.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("EspecialidadeMedico", b =>
                {
                    b.HasOne("MedClin.Models.Especialidade", null)
                        .WithMany()
                        .HasForeignKey("EspecialidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedClin.Models.Medico", null)
                        .WithMany()
                        .HasForeignKey("MedicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
