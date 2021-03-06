// <auto-generated />
using InlamningsuppgiftEntity;
using InlamningsuppgiftEntity.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InlamningsuppgiftEntity.Migrations
{
    [DbContext(typeof(GenealogiContext))]
    [Migration("20211218131045_added_people")]
    partial class added_people
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Far = 3,
                            LastName = "Gahan",
                            Mor = 2,
                            Name = "Dave"
                        },
                        new
                        {
                            Id = 2,
                            Far = 0,
                            LastName = "Gahan",
                            Mor = 0,
                            Name = "Sylvia"
                        },
                        new
                        {
                            Id = 3,
                            Far = 0,
                            LastName = "Gahan",
                            Mor = 0,
                            Name = "Len"
                        },
                        new
                        {
                            Id = 4,
                            Far = 3,
                            LastName = "Gahan",
                            Mor = 2,
                            Name = "Sue"
                        },
                        new
                        {
                            Id = 5,
                            Far = 7,
                            LastName = "Gahan",
                            Mor = 2,
                            Name = "Peter"
                        },
                        new
                        {
                            Id = 6,
                            Far = 7,
                            LastName = "Gahan",
                            Mor = 2,
                            Name = "Phil"
                        },
                        new
                        {
                            Id = 7,
                            Far = 0,
                            LastName = "Gahan",
                            Mor = 0,
                            Name = "Jack"
                        },
                        new
                        {
                            Id = 8,
                            Far = 1,
                            LastName = "Gahan",
                            Mor = 9,
                            Name = "Jack"
                        },
                        new
                        {
                            Id = 9,
                            Far = 0,
                            LastName = "Fox",
                            Mor = 0,
                            Name = "Joanne"
                        },
                        new
                        {
                            Id = 10,
                            Far = 1,
                            LastName = "Gahan",
                            Mor = 11,
                            Name = "Stella Rose"
                        },
                        new
                        {
                            Id = 11,
                            Far = 0,
                            LastName = "Sklias-Gahan",
                            Mor = 12,
                            Name = "Jennifer"
                        },
                        new
                        {
                            Id = 12,
                            Far = 0,
                            LastName = "Sklias",
                            Mor = 0,
                            Name = "Stella"
                        },
                        new
                        {
                            Id = 13,
                            Far = 0,
                            LastName = "Rogers-Gahan",
                            Mor = 11,
                            Name = "Jimmy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
