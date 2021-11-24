﻿// <auto-generated />
using System;
using Dotnet6EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dotnet6EFCore.Migrations
{
    [DbContext(typeof(EFCore6DBContext))]
    [Migration("20211124023354_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dotnet6EFCore.Model.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeetingId"), 1L, 1);

                    b.Property<DateTime?>("ENDDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MeetingId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Dotnet6EFCore.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NowMeetingMeetingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OnboardDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("NowMeetingMeetingId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dotnet6EFCore.Model.User", b =>
                {
                    b.HasOne("Dotnet6EFCore.Model.Meeting", "NowMeeting")
                        .WithMany()
                        .HasForeignKey("NowMeetingMeetingId");

                    b.Navigation("NowMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}