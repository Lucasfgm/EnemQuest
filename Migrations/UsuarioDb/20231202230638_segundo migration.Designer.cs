﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using info_app.Data;

#nullable disable

namespace EnemQuest.Migrations.UsuarioDb
{
    [DbContext(typeof(UsuarioDbContext))]
    [Migration("20231202230638_segundo migration")]
    partial class segundomigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("info_app.Data.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apelido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apelido = "Nessa",
                            Email = "nessa@mail.com",
                            Nome = "Vanessa",
                            Senha = "12345678",
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            Apelido = "Jose",
                            Email = "josejunior@mail.com",
                            Nome = "Jose Junior",
                            Senha = "12345678",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
