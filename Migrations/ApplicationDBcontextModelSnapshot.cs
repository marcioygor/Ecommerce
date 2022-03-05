﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteDeCompra.Data;

namespace SiteDeCompra.Migrations
{
    [DbContext(typeof(ApplicationDBcontext))]
    partial class ApplicationDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("SiteDeCompra.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("USR_CEP");

                    b.Property<string>("CPF")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("USR_CPF");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("USR_CELULAR");

                    b.Property<string>("ComplementoEndereco")
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)")
                        .HasColumnName("USR_COMPLEMENTO_ENDERECO");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("USR_ENDERECO");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("USR_ESTADO");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("USR_IDADE");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("USR_NOME");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("USR_TELEFONE");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("USR_TIPO");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("SiteDeCompra.Models.CompraUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CUS_ID");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("CUS_ESTADO");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QtdCompra")
                        .HasColumnType("int")
                        .HasColumnName("CSU_QTD");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UserId");

                    b.ToTable("TB_COMPRA_USUARIO");
                });

            modelBuilder.Entity("SiteDeCompra.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PRD_ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("PRD_DATA_ALTERACAO");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("PRD_DATA_CADASTRO");

                    b.Property<string>("Descricao")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("PRD_DESCRICAO");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("PRD_ESTADO");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PRD_NOME");

                    b.Property<string>("Observacao")
                        .HasMaxLength(20000)
                        .HasColumnType("longtext")
                        .HasColumnName("PRD_OBSERVACAO");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int")
                        .HasColumnName("PRD_QTD_ESTOQUE");

                    b.Property<string>("Url")
                        .HasColumnType("longtext")
                        .HasColumnName("PRD_URL");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("PRD_VALO");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SiteDeCompra.Models.CompraUsuario", b =>
                {
                    b.HasOne("SiteDeCompra.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("SiteDeCompra.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SiteDeCompra.Models.Produto", b =>
                {
                    b.HasOne("SiteDeCompra.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");
                });
#pragma warning restore 612, 618
        }
    }
}