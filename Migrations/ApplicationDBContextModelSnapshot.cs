﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiBodega.Data;

#nullable disable

namespace apiBodega.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apiBodega.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpresaID"));

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaID");

                    b.ToTable("empresas");

                    b.HasData(
                        new
                        {
                            EmpresaID = 1,
                            NombreEmpresa = "Supermaxi",
                            Resumen = "Empresa de viveres y consumo"
                        },
                        new
                        {
                            EmpresaID = 2,
                            NombreEmpresa = "ElectronicaEc",
                            Resumen = "Empresa que vende componentes eléctricos"
                        });
                });

            modelBuilder.Entity("apiBodega.Models.Pedidos", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<int>("CtdProducto")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("pedidos");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            CtdProducto = 54,
                            ProveedorId = 2
                        });
                });

            modelBuilder.Entity("apiBodega.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<int>("CtdenStock")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            CtdenStock = 300,
                            Descripcion = "Cloro para uso doméstico",
                            Nombre = "Clorox",
                            Precio = 5.9900000000000002,
                            ProveedorId = 1
                        },
                        new
                        {
                            ProductoId = 2,
                            CtdenStock = 89,
                            Descripcion = "Detergente en crema ideal para el lavado manual de vajilla",
                            Nombre = "Lava",
                            Precio = 6.9900000000000002,
                            ProveedorId = 1
                        },
                        new
                        {
                            ProductoId = 3,
                            CtdenStock = 4,
                            Descripcion = "Brochas para limpieza de componentes eléctricos",
                            Nombre = " Kit Brochas antiestáticas",
                            Precio = 3.5,
                            ProveedorId = 2
                        },
                        new
                        {
                            ProductoId = 4,
                            CtdenStock = 34,
                            Descripcion = "Alcohol Isopropilico al 90%",
                            Nombre = "Alcohol Isopropilico",
                            Precio = 6.7999999999999998,
                            ProveedorId = 2
                        });
                });

            modelBuilder.Entity("apiBodega.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            UserMail = "rick1234@gmail.com",
                            UserPassword = "admin4321"
                        },
                        new
                        {
                            IdUser = 2,
                            UserMail = "cris1234@gmail.com",
                            UserPassword = "admin1234"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
