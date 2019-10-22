﻿// <auto-generated />
using System;
using Fiap.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Infra.Data.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Domain.Entities.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCriacao")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdUsuarioAlteracao");

                    b.Property<int?>("IdUsuarioCriacao");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(100);

                    b.Property<string>("Preparo")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("QuantidadePessoas")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("TempoPreparo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Receita");
                });
#pragma warning restore 612, 618
        }
    }
}
