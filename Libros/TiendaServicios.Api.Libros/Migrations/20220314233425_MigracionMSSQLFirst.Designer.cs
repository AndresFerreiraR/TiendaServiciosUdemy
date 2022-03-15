﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaServicios.Api.Libros.Persistencia;

#nullable disable

namespace TiendaServicios.Api.Libros.Migrations
{
    [DbContext(typeof(ContextoLibreria))]
    [Migration("20220314233425_MigracionMSSQLFirst")]
    partial class MigracionMSSQLFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TiendaServicios.Api.Libros.Modelo.LibreriaMaterial", b =>
                {
                    b.Property<Guid?>("LibreriaMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AutorLibro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibreriaMaterialId");

                    b.ToTable("LibreriaMaterial");
                });
#pragma warning restore 612, 618
        }
    }
}
