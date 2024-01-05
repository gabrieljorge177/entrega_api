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
    [Migration("20240104164730_decimo")]
    partial class decimo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClientesCompras", b =>
                {
                    b.Property<int>("ClientesId_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("ComprasId_Compra")
                        .HasColumnType("int");

                    b.HasKey("ClientesId_Cliente", "ComprasId_Compra");

                    b.HasIndex("ComprasId_Compra");

                    b.ToTable("ClientesCompras");
                });

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

                    b.Property<string>("Metodo_Pagamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco_Compra")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id_Compra");

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

                    b.Property<int?>("ComprasId_Compra")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("data_passagem")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id_Passagem");

                    b.HasIndex("ComprasId_Compra");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("ClientesCompras", b =>
                {
                    b.HasOne("booking_api.Model.Clientes", null)
                        .WithMany()
                        .HasForeignKey("ClientesId_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("booking_api.Model.Compras", null)
                        .WithMany()
                        .HasForeignKey("ComprasId_Compra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("booking_api.Model.Passagens", b =>
                {
                    b.HasOne("booking_api.Model.Compras", "Compras")
                        .WithMany("Passagens")
                        .HasForeignKey("ComprasId_Compra");

                    b.Navigation("Compras");
                });

            modelBuilder.Entity("booking_api.Model.Compras", b =>
                {
                    b.Navigation("Passagens");
                });
#pragma warning restore 612, 618
        }
    }
}
