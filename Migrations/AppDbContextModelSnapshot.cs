﻿// <auto-generated />
using System;
using DestinoComum2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DestinoComum2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DestinoComum2.Models.CidadeModel", b =>
                {
                    b.Property<int>("IdCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCidade"));

                    b.Property<string>("Acessibilidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alimentacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PontoTuristico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transporte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCidade");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("DestinoComum2.Models.ComentarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CidadeComentarioId")
                        .HasColumnType("int");

                    b.Property<int?>("CidadeIdCidade")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacaoComentario")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataComentario")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CidadeIdCidade");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("DestinoComum2.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Situacao")
                        .HasColumnType("bit");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DestinoComum2.Models.ComentarioModel", b =>
                {
                    b.HasOne("DestinoComum2.Models.CidadeModel", "Cidade")
                        .WithMany("Comentarios")
                        .HasForeignKey("CidadeIdCidade");

                    b.HasOne("DestinoComum2.Models.UsuarioModel", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("DestinoComum2.Models.CidadeModel", b =>
                {
                    b.Navigation("Comentarios");
                });

            modelBuilder.Entity("DestinoComum2.Models.UsuarioModel", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
