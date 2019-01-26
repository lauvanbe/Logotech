﻿// <auto-generated />
using System;
using Logotech.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logotech.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Logotech.API.Models.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BoitePostal");

                    b.Property<int>("CodePostal");

                    b.Property<int>("NumeroRue");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("Rue")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("Logotech.API.Models.Fonction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("Fonctions");
                });

            modelBuilder.Entity("Logotech.API.Models.Lateralite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("Lateralites");
                });

            modelBuilder.Entity("Logotech.API.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdresseId");

                    b.Property<string>("Anamnèse")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("Commentaire")
                        .HasMaxLength(250);

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("Gsm");

                    b.Property<int>("LateraliteId");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("PersonneContact")
                        .HasMaxLength(55);

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<int?>("TelContact");

                    b.Property<int?>("TelFixe");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId");

                    b.HasIndex("LateraliteId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Logotech.API.Models.Praticien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdresseId");

                    b.Property<bool>("Deplacement");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("FonctionId");

                    b.Property<int>("Gsm");

                    b.Property<int>("Inami");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<int>("SpecialisationId");

                    b.Property<int>("TelFixe");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId");

                    b.HasIndex("FonctionId");

                    b.HasIndex("SpecialisationId");

                    b.ToTable("Praticiens");
                });

            modelBuilder.Entity("Logotech.API.Models.Specialisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("Specialisations");
                });

            modelBuilder.Entity("Logotech.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Logotech.API.Models.Patient", b =>
                {
                    b.HasOne("Logotech.API.Models.Adresse", "Adresse")
                        .WithMany("Patients")
                        .HasForeignKey("AdresseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Logotech.API.Models.Lateralite", "Lateralite")
                        .WithMany("Patients")
                        .HasForeignKey("LateraliteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Logotech.API.Models.Praticien", b =>
                {
                    b.HasOne("Logotech.API.Models.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Logotech.API.Models.Fonction", "Fonction")
                        .WithMany()
                        .HasForeignKey("FonctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Logotech.API.Models.Specialisation", "Specialisation")
                        .WithMany()
                        .HasForeignKey("SpecialisationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
