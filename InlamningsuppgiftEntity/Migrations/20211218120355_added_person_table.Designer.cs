﻿// <auto-generated />
using InlamningsuppgiftEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InlamningsuppgiftEntity.Migrations
{
    [DbContext(typeof(GenealogiContext))]
    [Migration("20211218120355_added_person_table")]
    partial class added_person_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InlamningsuppgiftEntity.GenealogiCRUD", b =>
                {
                    b.Property<string>("DatabaseName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxRows")
                        .HasColumnType("int");

                    b.Property<string>("OrderBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DatabaseName");

                    b.ToTable("MyRelatives");
                });

            modelBuilder.Entity("InlamningsuppgiftEntity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Far")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MyPeople");
                });
#pragma warning restore 612, 618
        }
    }
}
