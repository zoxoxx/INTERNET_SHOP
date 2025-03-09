﻿// <auto-generated />
using System;
using INTERNET_SHOP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INTERNET_SHOP.Migrations
{
    [DbContext(typeof(INTERNET_SHOPContext))]
    partial class INTERNET_SHOPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("INTERNET_SHOP.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CityId1");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("NumberSeats")
                        .HasColumnType("int");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Hall");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTimeOrder")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("NumberRow")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("TimeRun")
                        .HasColumnType("time");

                    b.Property<int>("TypeProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("TypeProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountTickets")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateEvent")
                        .HasColumnType("date");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("TimeEndEvent")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("TimeStartEvent")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("ProductId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId1")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserAutorizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("PositionId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("ScheduleId1");

                    b.HasIndex("UserAutorizeId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.TypeProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeProducts");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExternalIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerProcessor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PcName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.UserAutorize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserAutorize");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Cinema", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.City", null)
                        .WithMany("Cinemas")
                        .HasForeignKey("CityId1");

                    b.Navigation("City");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Hall", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.Cinema", "Cinema")
                        .WithMany("Halls")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Product", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.Cinema", "Cinema")
                        .WithMany("Products")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.TypeProduct", "TypeProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Schedule", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Ticket", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.City", null)
                        .WithMany("Tickets")
                        .HasForeignKey("CityId");

                    b.HasOne("INTERNET_SHOP.Models.Order", "Order")
                        .WithOne("Ticket")
                        .HasForeignKey("INTERNET_SHOP.Models.Ticket", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.Product", "Product")
                        .WithMany("Tickets")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("INTERNET_SHOP.Models.Schedule", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ScheduleId1");

                    b.HasOne("INTERNET_SHOP.Models.UserAutorize", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserAutorizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Position");

                    b.Navigation("Product");

                    b.Navigation("Schedule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.UserAutorize", b =>
                {
                    b.HasOne("INTERNET_SHOP.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Cinema", b =>
                {
                    b.Navigation("Halls");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.City", b =>
                {
                    b.Navigation("Cinemas");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Order", b =>
                {
                    b.Navigation("Ticket")
                        .IsRequired();
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Product", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.Schedule", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.TypeProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("INTERNET_SHOP.Models.UserAutorize", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
