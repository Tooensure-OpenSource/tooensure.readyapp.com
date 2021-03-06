// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadyApp.Data;

namespace ReadyApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211017063342_NewStructure")]
    partial class NewStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeEmployer", b =>
                {
                    b.Property<Guid>("EmployeesEmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployersEmployerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesEmployeeId", "EmployersEmployerId");

                    b.HasIndex("EmployersEmployerId");

                    b.ToTable("EmployeeEmployer");
                });

            modelBuilder.Entity("OrderOrderItem", b =>
                {
                    b.Property<Guid>("OrderItemsOrderItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrdersOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderItemsOrderItemId", "OrdersOrderId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("OrderOrderItem");
                });

            modelBuilder.Entity("ProductProductItem", b =>
                {
                    b.Property<Guid>("ProductItemsProductItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductReferancesProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductItemsProductItemId", "ProductReferancesProductId");

                    b.HasIndex("ProductReferancesProductId");

                    b.ToTable("ProductProductItem");
                });

            modelBuilder.Entity("ReadyApp.Domain.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entities.Employer", b =>
                {
                    b.Property<Guid>("EmployerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployerId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.Business", b =>
                {
                    b.Property<Guid>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessId");

                    b.HasIndex("EmployerId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReadyApp.Domain.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsReady")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("BusinessId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ReadyApp.Domain.OrderItem", b =>
                {
                    b.Property<Guid>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ReadyApp.Domain.Owner", b =>
                {
                    b.Property<Guid>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ownerhship")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OwnerId");

                    b.HasIndex("BusinessId");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ReadyApp.Domain.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceTag")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("BusinessId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ReadyApp.Domain.ProductItem", b =>
                {
                    b.Property<Guid>("ProductItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExperationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductItemId");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("EmployeeEmployer", b =>
                {
                    b.HasOne("ReadyApp.Domain.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadyApp.Domain.Entities.Employer", null)
                        .WithMany()
                        .HasForeignKey("EmployersEmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderOrderItem", b =>
                {
                    b.HasOne("ReadyApp.Domain.OrderItem", null)
                        .WithMany()
                        .HasForeignKey("OrderItemsOrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadyApp.Domain.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductProductItem", b =>
                {
                    b.HasOne("ReadyApp.Domain.ProductItem", null)
                        .WithMany()
                        .HasForeignKey("ProductItemsProductItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadyApp.Domain.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductReferancesProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.Business", b =>
                {
                    b.HasOne("ReadyApp.Domain.Entities.Employer", "Employer")
                        .WithMany("Businesses")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.User", b =>
                {
                    b.HasOne("ReadyApp.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ReadyApp.Domain.Order", b =>
                {
                    b.HasOne("ReadyApp.Domain.Entity.Business", "Business")
                        .WithMany("Orders")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadyApp.Domain.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReadyApp.Domain.OrderItem", b =>
                {
                    b.HasOne("ReadyApp.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ReadyApp.Domain.Owner", b =>
                {
                    b.HasOne("ReadyApp.Domain.Entity.Business", "Business")
                        .WithMany("Owners")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadyApp.Domain.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReadyApp.Domain.Product", b =>
                {
                    b.HasOne("ReadyApp.Domain.Entity.Business", null)
                        .WithMany("Products")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entities.Employer", b =>
                {
                    b.Navigation("Businesses");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.Business", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Owners");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ReadyApp.Domain.Entity.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
