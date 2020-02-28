﻿// <auto-generated />
using System;
using FF_XII_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FF_XII_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200227192130_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FF_XII_API.Domain.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AP")
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("LP")
                        .HasColumnType("int");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("Money")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("XP")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderId = 1,
                            Name = "Personagem 1"
                        },
                        new
                        {
                            Id = 2,
                            GenderId = 2,
                            Name = "Personagem 2"
                        });
                });

            modelBuilder.Entity("FF_XII_API.Domain.Models.CharacterGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CharacterGender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gênero 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gênero 2"
                        });
                });

            modelBuilder.Entity("FF_XII_API.Domain.Models.CharacterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CharacterType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tipo 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tipo 2"
                        });
                });

            modelBuilder.Entity("FF_XII_API.Domain.Models.CharacterTypeCharacter", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterTypeId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "CharacterTypeId");

                    b.HasIndex("CharacterTypeId");

                    b.ToTable("CharacterTypeCharacter");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            CharacterTypeId = 1
                        },
                        new
                        {
                            CharacterId = 1,
                            CharacterTypeId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            CharacterTypeId = 1
                        });
                });

            modelBuilder.Entity("FF_XII_API.Domain.Models.Character", b =>
                {
                    b.HasOne("FF_XII_API.Domain.Models.CharacterGender", "Gender")
                        .WithMany("Characters")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FF_XII_API.Domain.Models.CharacterTypeCharacter", b =>
                {
                    b.HasOne("FF_XII_API.Domain.Models.Character", "Character")
                        .WithMany("CharacterTypes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FF_XII_API.Domain.Models.CharacterType", "CharacterType")
                        .WithMany("Characters")
                        .HasForeignKey("CharacterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
