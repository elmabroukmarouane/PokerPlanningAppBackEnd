﻿// <auto-generated />
using System;
using Infrastructure.Models.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Infrastructure.Models.Classes.Duration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<int>("duration")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("durations");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 332, DateTimeKind.Local).AddTicks(9766),
                            createdby = "Seed Data",
                            duration = 60,
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 334, DateTimeKind.Local).AddTicks(8325),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("groupname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("groups");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4640),
                            createdby = "Seed Data",
                            groupname = "Group 1",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4657),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4671),
                            createdby = "Seed Data",
                            groupname = "Group 2",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4674),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4677),
                            createdby = "Seed Data",
                            groupname = "Group 3",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4680),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Issue", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("assignedto")
                        .HasColumnType("text");

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("number")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnType("text");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("issues");

                    b.HasData(
                        new
                        {
                            id = 1,
                            assignedto = "EL MABROUK Marouane",
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1030),
                            createdby = "Seed Data",
                            number = "#1",
                            title = "Issue 1",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1047),
                            updatedby = "Seed Data",
                            url = "https://google.com/",
                            weight = 4
                        },
                        new
                        {
                            id = 2,
                            assignedto = "JOHN Smith",
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1061),
                            createdby = "Seed Data",
                            number = "#2",
                            title = "Issue 2",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1064),
                            updatedby = "Seed Data",
                            url = "https://google.com/",
                            weight = 4
                        },
                        new
                        {
                            id = 3,
                            assignedto = "MILLER William",
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1067),
                            createdby = "Seed Data",
                            number = "#3",
                            title = "Issue 3",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1070),
                            updatedby = "Seed Data",
                            url = "https://google.com/",
                            weight = 4
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<int>("groupid")
                        .HasColumnType("integer");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("groupid");

                    b.ToTable("persons");

                    b.HasData(
                        new
                        {
                            id = 1,
                            birthdate = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5119),
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5291),
                            createdby = "Seed Data",
                            firstname = "Marouane",
                            groupid = 1,
                            lastname = "EL MABROUK",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5297),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            birthdate = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5312),
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5314),
                            createdby = "Seed Data",
                            firstname = "Smith",
                            groupid = 2,
                            lastname = "JOHN",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5317),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            birthdate = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5320),
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5322),
                            createdby = "Seed Data",
                            firstname = "William",
                            groupid = 3,
                            lastname = "MILLER",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5325),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1396),
                            createdby = "Seed Data",
                            description = "Super Administrator Description",
                            role = 1,
                            title = "Super Administrator",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1412),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1426),
                            createdby = "Seed Data",
                            description = "Administrator Description",
                            role = 2,
                            title = "Administrator",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1428),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1432),
                            createdby = "Seed Data",
                            description = "User Description",
                            role = 3,
                            title = "User",
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1434),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("personid")
                        .HasColumnType("integer");

                    b.Property<int>("roleid")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("personid");

                    b.HasIndex("roleid");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2692),
                            createdby = "Seed Data",
                            email = "user1@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 1,
                            roleid = 1,
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2713),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3059),
                            createdby = "Seed Data",
                            email = "user2@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 2,
                            roleid = 2,
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3063),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3107),
                            createdby = "Seed Data",
                            email = "user3@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 3,
                            roleid = 3,
                            updatedat = new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3110),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Person", b =>
                {
                    b.HasOne("Infrastructure.Models.Classes.Group", "group")
                        .WithMany("persons")
                        .HasForeignKey("groupid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("group");
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.User", b =>
                {
                    b.HasOne("Infrastructure.Models.Classes.Person", "person")
                        .WithMany("users")
                        .HasForeignKey("personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Classes.Role", "role")
                        .WithMany("users")
                        .HasForeignKey("roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");

                    b.Navigation("role");
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Group", b =>
                {
                    b.Navigation("persons");
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Person", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Role", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
