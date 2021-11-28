﻿// <auto-generated />
using System;
using ImprovedWorkCenter.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImprovedWorkCenter.Migrations
{
    [DbContext(typeof(ImprovedWorkCenterContext))]
    partial class ImprovedWorkCenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImprovedWorkCenter.Models.Actividad", b =>
                {
                    b.Property<int>("ActividadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioFinal")
                        .HasColumnType("int");

                    b.Property<int>("HorarioInicio")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("ActividadId");

                    b.HasIndex("ClubId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.ActividadSocio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("SocioId");

                    b.ToTable("ActividadSocios");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("TipoPlan")
                        .HasColumnType("int");

                    b.HasKey("PlanId");

                    b.HasIndex("ClubId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Socio", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("Contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<bool>("EsDeudor")
                        .HasColumnType("bit");

                    b.Property<string>("FechaInscripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetodoDePago")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocioId");

                    b.HasIndex("ClubId");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Actividad", b =>
                {
                    b.HasOne("ImprovedWorkCenter.Models.Club", null)
                        .WithMany("ListaActividades")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.ActividadSocio", b =>
                {
                    b.HasOne("ImprovedWorkCenter.Models.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImprovedWorkCenter.Models.Socio", "Socio")
                        .WithMany()
                        .HasForeignKey("SocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Plan", b =>
                {
                    b.HasOne("ImprovedWorkCenter.Models.Club", null)
                        .WithMany("ListaPlanes")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("ImprovedWorkCenter.Models.Socio", b =>
                {
                    b.HasOne("ImprovedWorkCenter.Models.Club", null)
                        .WithMany("ListaSocios")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
