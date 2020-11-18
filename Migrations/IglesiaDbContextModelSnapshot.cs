﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ej9.Data;

namespace ej9.Migrations
{
    [DbContext(typeof(IglesiaDbContext))]
    partial class IglesiaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ej9.Data.Iglesia", b =>
                {
                    b.Property<int>("IglesiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<int>("Celular")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ciudadactual")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ciudadnacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Correoelectrónico")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .HasColumnType("TEXT");

                    b.Property<string>("Documentoidentidad")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Paísactual")
                        .HasColumnType("TEXT");

                    b.Property<string>("Paísnacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Teléfono")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipoidenti")
                        .HasColumnType("TEXT");

                    b.HasKey("IglesiaId");

                    b.ToTable("Iglesias");
                });
#pragma warning restore 612, 618
        }
    }
}