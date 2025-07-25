﻿// <auto-generated />
using System;
using ChoirManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChoirManager.Migrations
{
    [DbContext(typeof(ChoirDbContext))]
    partial class ChoirDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChoirManager.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("MassId")
                        .HasColumnType("integer");

                    b.Property<int?>("RehearsalId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<bool>("WasPresent")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("MassId");

                    b.HasIndex("RehearsalId");

                    b.HasIndex("StudentId");

                    b.ToTable("AttendanceRecords");
                });

            modelBuilder.Entity("ChoirManager.Models.Mass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Masses");
                });

            modelBuilder.Entity("ChoirManager.Models.Rehearsal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Rehearsals");
                });

            modelBuilder.Entity("ChoirManager.Models.SoloAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MassId")
                        .HasColumnType("integer");

                    b.Property<string>("SoloTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<bool>("WasPerformed")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("MassId");

                    b.HasIndex("StudentId");

                    b.ToTable("SoloAssignments");
                });

            modelBuilder.Entity("ChoirManager.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ParentFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ParentLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WantsSolos")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ChoirManager.Models.Attendance", b =>
                {
                    b.HasOne("ChoirManager.Models.Mass", "Mass")
                        .WithMany()
                        .HasForeignKey("MassId");

                    b.HasOne("ChoirManager.Models.Rehearsal", "Rehearsal")
                        .WithMany()
                        .HasForeignKey("RehearsalId");

                    b.HasOne("ChoirManager.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mass");

                    b.Navigation("Rehearsal");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ChoirManager.Models.SoloAssignment", b =>
                {
                    b.HasOne("ChoirManager.Models.Mass", "Mass")
                        .WithMany()
                        .HasForeignKey("MassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChoirManager.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mass");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
