﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XYZ_Hotels.DB;

#nullable disable

namespace XYZ_Hotels.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230526073331_hotel")]
    partial class hotel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library.Models.Hotels", b =>
                {
                    b.Property<int>("Hid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hid"));

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Htype")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Hid");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Library.Models.Rooms", b =>
                {
                    b.Property<int>("Rid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Rid"));

                    b.Property<int>("Hid")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Room_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rid");

                    b.HasIndex("Hid");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("XYZ_Hotels.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library.Models.Rooms", b =>
                {
                    b.HasOne("Library.Models.Hotels", "Hotels")
                        .WithMany("Rooms")
                        .HasForeignKey("Hid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("Library.Models.Hotels", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
