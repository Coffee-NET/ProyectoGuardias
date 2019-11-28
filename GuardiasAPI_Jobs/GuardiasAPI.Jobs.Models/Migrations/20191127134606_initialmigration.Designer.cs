﻿// <auto-generated />
using GuardiasAPI.Jobs.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuardiasAPI.Jobs.Models.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20191127134606_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuardiasAPI.Jobs.Models.Context.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("Horario")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("PostRequisitos");

                    b.Property<string>("PreRequisitos");

                    b.Property<string>("Sigla")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}