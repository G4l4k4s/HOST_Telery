﻿// <auto-generated />
using System;
using HOST_Telery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HOST_Telery.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HOST_Telery.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<int>("GiestId")
                        .HasColumnType("int");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double")
                        .HasColumnName("total_cost");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GiestId");

                    b.HasIndex("RoomId");

                    b.ToTable("boolings");
                });

            modelBuilder.Entity("HOST_Telery.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_firstName");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_identificationNumber");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_lastName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_password");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("HOST_Telery.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BristDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("guest_arrivalDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("guest_email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("guest_firstname");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("guest_identificationNumber");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("guest_lastname");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("guest_phoneNumber");

                    b.HasKey("Id");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("HOST_Telery.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availavility")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("room_availability");

                    b.Property<byte>("MaxOccupancyPerPerson")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("max_occupancy_per_sperson");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("HOST_Telery.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_description");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_type_name");

                    b.HasKey("Id");

                    b.ToTable("room_types");
                });

            modelBuilder.Entity("HOST_Telery.Models.Booking", b =>
                {
                    b.HasOne("HOST_Telery.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HOST_Telery.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GiestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HOST_Telery.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HOST_Telery.Models.Room", b =>
                {
                    b.HasOne("HOST_Telery.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
