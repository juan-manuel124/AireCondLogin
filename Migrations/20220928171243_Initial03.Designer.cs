﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AiresAcondDomi.Migrations
{
    [DbContext(typeof(AppAuthDbContext))]
    [Migration("20220928171243_Initial03")]
    partial class Initial03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AiresAcondDomi.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Servicios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Servicio")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.SugerenciaMantenimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaId");

                    b.ToTable("SugerenciaMantenimiento");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Cliente", b =>
                {
                    b.HasBaseType("AiresAcondDomi.Models.Persona");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaId")
                        .HasColumnType("int");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.Property<int>("RepuestoId")
                        .HasColumnType("int");

                    b.Property<int>("TecnicoId")
                        .HasColumnType("int");

                    b.HasIndex("HistoriaId");

                    b.HasIndex("ProfesionalId");

                    b.HasIndex("RepuestoId");

                    b.HasIndex("TecnicoId");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Historia", b =>
                {
                    b.HasBaseType("AiresAcondDomi.Models.Persona");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entorno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Historia");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.ProfecionalDesignado", b =>
                {
                    b.HasBaseType("AiresAcondDomi.Models.Persona");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ProfecionalDesignado");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Profesional", b =>
                {
                    b.HasBaseType("AiresAcondDomi.Models.Persona");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetaProfecional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesional");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Repuesto", b =>
                {
                    b.HasBaseType("AiresAcondDomi.Models.Persona");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombrePieza")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Repuesto");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Servicios", b =>
                {
                    b.HasOne("AiresAcondDomi.Models.Cliente", null)
                        .WithMany("Servicio")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.SugerenciaMantenimiento", b =>
                {
                    b.HasOne("AiresAcondDomi.Models.Historia", null)
                        .WithMany("SugerenciaMantenimiento")
                        .HasForeignKey("HistoriaId");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Cliente", b =>
                {
                    b.HasOne("AiresAcondDomi.Models.Historia", "Historia")
                        .WithMany()
                        .HasForeignKey("HistoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiresAcondDomi.Models.Profesional", "Profesional")
                        .WithMany()
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiresAcondDomi.Models.Repuesto", "Repuesto")
                        .WithMany()
                        .HasForeignKey("RepuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AiresAcondDomi.Models.ProfecionalDesignado", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Historia");

                    b.Navigation("Profesional");

                    b.Navigation("Repuesto");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Cliente", b =>
                {
                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("AiresAcondDomi.Models.Historia", b =>
                {
                    b.Navigation("SugerenciaMantenimiento");
                });
#pragma warning restore 612, 618
        }
    }
}