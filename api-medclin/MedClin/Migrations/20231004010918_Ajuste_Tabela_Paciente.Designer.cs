﻿// <auto-generated />
using MedClin.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedClin.Migrations
{
    [DbContext(typeof(PacienteRepository))]
    [Migration("20231004010918_Ajuste_Tabela_Paciente")]
    partial class Ajuste_Tabela_Paciente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedClin.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("MedClin.Models.Paciente", b =>
                {
                    b.OwnsOne("MedClin.Models.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("PacienteId")
                                .HasColumnType("int");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Bairro");

                            b1.Property<string>("Complemento")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Complemento");

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Estado");

                            b1.Property<string>("Municipio")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Municipio");

                            b1.Property<int>("Numero")
                                .HasColumnType("int")
                                .HasColumnName("Numero");

                            b1.Property<string>("Rua")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Rua");

                            b1.HasKey("PacienteId");

                            b1.ToTable("Paciente");

                            b1.WithOwner()
                                .HasForeignKey("PacienteId");
                        });

                    b.Navigation("Endereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
