﻿// <auto-generated />
using InternsManager.DAL.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InternsManager.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InternsManager.DAL.Entities.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdmin"), 1L, 1);

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdmin");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            IdAdmin = 1,
                            IdPerson = 7,
                            Password = "$2a$11$oxugnHJQ1NUogyxXyN5tEedqgTmNFSYw.WBBVER5UVOSFsaathz3y",
                            Username = "SNeagu"
                        });
                });

            modelBuilder.Entity("InternsManager.DAL.Entities.Intern", b =>
                {
                    b.Property<int>("IdIntern")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIntern"), 1L, 1);

                    b.Property<int>("IdInternship")
                        .HasColumnType("int");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<int>("VacationDays")
                        .HasColumnType("int");

                    b.HasKey("IdIntern");

                    b.ToTable("Interns");

                    b.HasData(
                        new
                        {
                            IdIntern = 1,
                            IdInternship = 1,
                            IdPerson = 1,
                            VacationDays = 28
                        },
                        new
                        {
                            IdIntern = 2,
                            IdInternship = 2,
                            IdPerson = 2,
                            VacationDays = 26
                        },
                        new
                        {
                            IdIntern = 3,
                            IdInternship = 3,
                            IdPerson = 3,
                            VacationDays = 28
                        },
                        new
                        {
                            IdIntern = 4,
                            IdInternship = 4,
                            IdPerson = 4,
                            VacationDays = 28
                        },
                        new
                        {
                            IdIntern = 5,
                            IdInternship = 4,
                            IdPerson = 5,
                            VacationDays = 28
                        },
                        new
                        {
                            IdIntern = 6,
                            IdInternship = 3,
                            IdPerson = 6,
                            VacationDays = 28
                        });
                });

            modelBuilder.Entity("InternsManager.DAL.Entities.Internship", b =>
                {
                    b.Property<int>("IdInternship")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInternship"), 1L, 1);

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryBRUT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInternship");

                    b.ToTable("Internships");

                    b.HasData(
                        new
                        {
                            IdInternship = 1,
                            EndDate = "2022-07-14",
                            Name = "DiscoverIT",
                            Position = "Software Engineer",
                            SalaryBRUT = "1500 Lei",
                            StartDate = "2022-06-01"
                        },
                        new
                        {
                            IdInternship = 2,
                            EndDate = "2022-08-22",
                            Name = "QA Internship",
                            Position = "QA",
                            SalaryBRUT = "1750 Lei",
                            StartDate = "2022-05-23"
                        },
                        new
                        {
                            IdInternship = 3,
                            EndDate = "2022-09-14",
                            Name = "TriangleXperience",
                            Position = "Web Develover",
                            SalaryBRUT = "1500 Lei",
                            StartDate = "2022-06-15"
                        },
                        new
                        {
                            IdInternship = 4,
                            EndDate = "2022-09-19",
                            Name = "TetraTech",
                            Position = "Junior Programmer",
                            SalaryBRUT = "1620 Lei",
                            StartDate = "2022-06-20"
                        });
                });

            modelBuilder.Entity("InternsManager.DAL.Entities.Person", b =>
                {
                    b.Property<int>("IdPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerson"), 1L, 1);

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPerson");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            IdPerson = 1,
                            DateOfBirth = "2002-05-04",
                            Gender = "M",
                            Name = "Alexandru Ivanoff",
                            PicPath = "https://cdn.pixabay.com/photo/2017/11/26/00/30/teen-2977908_960_720.jpg"
                        },
                        new
                        {
                            IdPerson = 2,
                            DateOfBirth = "1990-11-12",
                            Gender = "F",
                            Name = "Irina Defta",
                            PicPath = "https://cdn.pixabay.com/photo/2015/03/03/18/58/woman-657753_1280.jpg"
                        },
                        new
                        {
                            IdPerson = 3,
                            DateOfBirth = "2002-02-23",
                            Gender = "M",
                            Name = "Florian-Andrei Barbu",
                            PicPath = "https://cdn.pixabay.com/photo/2016/03/04/21/24/portrait-1236732_1280.jpg"
                        },
                        new
                        {
                            IdPerson = 4,
                            DateOfBirth = "2002-02-02",
                            Gender = "M",
                            Name = "Augustin Petrica",
                            PicPath = "https://cdn.pixabay.com/photo/2020/03/01/22/43/young-4894362_1280.jpg"
                        },
                        new
                        {
                            IdPerson = 5,
                            DateOfBirth = "2000-09-05",
                            Gender = "F",
                            Name = "Oana Cretu",
                            PicPath = "https://cdn.pixabay.com/photo/2018/08/03/16/14/young-girl-3582188_1280.jpg"
                        },
                        new
                        {
                            IdPerson = 6,
                            DateOfBirth = "2001-11-29",
                            Gender = "F",
                            Name = "Ema Drobescu",
                            PicPath = "https://cdn.pixabay.com/photo/2017/08/28/16/29/portrait-2690308_1280.jpg"
                        },
                        new
                        {
                            IdPerson = 7,
                            DateOfBirth = "1977-03-07",
                            Gender = "F",
                            Name = "Stefania Neagu",
                            PicPath = "https://pixabay.com/get/gffc1d520603515ef286493847cebeab3b46d1b6e29250bceac008431920a5570bd6cc874b1efe2e58a3e766271af1e9329582245e58ae87739687318cae97df6a4e690a31d0245e9ff5b808edc166aa6_1920.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
