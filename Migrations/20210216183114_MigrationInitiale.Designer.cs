// <auto-generated />
using System;
using LeCorrecteur.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeCorrecteur.Migrations
{
    [DbContext(typeof(LeCorrecteurContext))]
    [Migration("20210216183114_MigrationInitiale")]
    partial class MigrationInitiale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LeCorrecteur.Models.Competence", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrilleID")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ponderation")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GrilleID");

                    b.ToTable("Competence");
                });

            modelBuilder.Entity("LeCorrecteur.Models.Grille", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Grille");
                });

            modelBuilder.Entity("LeCorrecteur.Models.Competence", b =>
                {
                    b.HasOne("LeCorrecteur.Models.Grille", null)
                        .WithMany("Competences")
                        .HasForeignKey("GrilleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeCorrecteur.Models.Grille", b =>
                {
                    b.Navigation("Competences");
                });
#pragma warning restore 612, 618
        }
    }
}
