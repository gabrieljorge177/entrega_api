﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using booking_api.Context;

#nullable disable

namespace booking_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240105121543_r")]
    partial class r
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("booking_api.Model.Clientes", b =>
                {
                    b.Property<int>("Id_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Acompanhantes")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("booking_api.Model.Compras", b =>
                {
                    b.Property<int>("Id_Compra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Compra")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Passagem")
                        .HasColumnType("int");

                    b.Property<string>("Metodo_Pagamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco_Compra")
                        .HasColumnType("double");

                    b.HasKey("Id_Compra");

                    b.HasIndex("Id_Cliente");

                    b.HasIndex("Id_Passagem");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("booking_api.Model.Passagens", b =>
                {
                    b.Property<int>("Id_Passagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<DateTime>("data_passagem")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id_Passagem");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("booking_api.Model.Compras", b =>
                {
                    b.HasOne("booking_api.Model.Clientes", "Clientes")
                        .WithMany("Compras")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("booking_api.Model.Passagens", "Passagens")
                        .WithMany("Compras")
                        .HasForeignKey("Id_Passagem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Passagens");
                });

            modelBuilder.Entity("booking_api.Model.Clientes", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("booking_api.Model.Passagens", b =>
                {
                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}