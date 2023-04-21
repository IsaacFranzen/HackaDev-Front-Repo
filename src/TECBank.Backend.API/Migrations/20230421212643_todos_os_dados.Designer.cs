﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TECBank.Backend.Repository.DataContext;

#nullable disable

namespace TECBank.Backend.Migrations
{
    [DbContext(typeof(TecBankContext))]
    [Migration("20230421212643_todos_os_dados")]
    partial class todos_os_dados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Domain.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("AlteradoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ExcluidoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Patrimonio")
                        .HasColumnType("REAL");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("RendaMensal")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("RgDataEmissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("RgEstado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RgNumero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RgOrgaoExpedidor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TelefoneCelular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoneEmpresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoneResidencial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Domain.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("AlteradoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ExcluidoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Domain.Model.Cliente", b =>
                {
                    b.HasOne("Domain.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
