﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using u20649232_HW01_API.Data;

#nullable disable

namespace u20649232_HW01_API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("u20649232_HW01_API.Models.CourseListing", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseId"));

                    b.Property<string>("courseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("courseId");

                    b.ToTable("courseListings");

                    b.HasData(
                        new
                        {
                            courseId = 1,
                            courseDescription = "Project teams and project managment",
                            courseDuration = "Semester 1",
                            courseName = "INF315"
                        },
                        new
                        {
                            courseId = 2,
                            courseDescription = "Fundamentals of prgramming in C# webforms",
                            courseDuration = "Semester 1",
                            courseName = "INF154"
                        },
                        new
                        {
                            courseId = 3,
                            courseDescription = "Fundamentals of html,css and javascript",
                            courseDuration = "Semester 2",
                            courseName = "INF164"
                        },
                        new
                        {
                            courseId = 4,
                            courseDescription = "Advanced programming in MVC & databases",
                            courseDuration = "Year",
                            courseName = "INF272"
                        },
                        new
                        {
                            courseId = 5,
                            courseDescription = "Advanced programming in sql, angular and api",
                            courseDuration = "Semester 1",
                            courseName = "INF354"
                        },
                        new
                        {
                            courseId = 6,
                            courseDescription = "Fundamentals into systems architecture",
                            courseDuration = "Year",
                            courseName = "INF171"
                        },
                        new
                        {
                            courseId = 7,
                            courseDescription = "Advanced system moddelling and sysetsms analysis",
                            courseDuration = "Year",
                            courseName = "INF271"
                        },
                        new
                        {
                            courseId = 8,
                            courseDescription = "Full systems development life cycle project",
                            courseDuration = "Year",
                            courseName = "INF370"
                        },
                        new
                        {
                            courseId = 9,
                            courseDescription = "Tends in IT",
                            courseDuration = "Semester 2",
                            courseName = "INF324"
                        },
                        new
                        {
                            courseId = 10,
                            courseDescription = "Knowledge managment in organisation at coprate strategic level",
                            courseDuration = "Semester 2",
                            courseName = "INL320"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
