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

                    b.Property<DateTime?>("createdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<int>("duration")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("durations");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 322, DateTimeKind.Local).AddTicks(5983),
                            createdby = "Seed Data",
                            duration = 60,
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 323, DateTimeKind.Local).AddTicks(6029),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("groupname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("groups");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5443),
                            createdby = "Seed Data",
                            groupname = "Group 1",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5451),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5461),
                            createdby = "Seed Data",
                            groupname = "Group 2",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5462),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5464),
                            createdby = "Seed Data",
                            groupname = "Group 3",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5465),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 4,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5467),
                            createdby = "Seed Data",
                            groupname = "Group 4",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5468),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 5,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5469),
                            createdby = "Seed Data",
                            groupname = "Group 5",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5471),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 6,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5474),
                            createdby = "Seed Data",
                            groupname = "Group 6",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5475),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 7,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5477),
                            createdby = "Seed Data",
                            groupname = "Group 7",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5478),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 8,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5479),
                            createdby = "Seed Data",
                            groupname = "Group 8",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5481),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 9,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5482),
                            createdby = "Seed Data",
                            groupname = "Group 9",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5483),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 10,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5485),
                            createdby = "Seed Data",
                            groupname = "Group 10",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5487),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 11,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5488),
                            createdby = "Seed Data",
                            groupname = "Group 11",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5489),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 12,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5491),
                            createdby = "Seed Data",
                            groupname = "Group 12",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5492),
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

                    b.Property<DateTime?>("createdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("number")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedate")
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
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8862),
                            createdby = "Seed Data",
                            number = "#1",
                            title = "Issue 1",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8870),
                            updatedby = "Seed Data",
                            url = "https://google.com/",
                            weight = 4
                        },
                        new
                        {
                            id = 2,
                            assignedto = "JOHN Smith",
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8877),
                            createdby = "Seed Data",
                            number = "#2",
                            title = "Issue 2",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8879),
                            updatedby = "Seed Data",
                            url = "https://google.com/",
                            weight = 4
                        },
                        new
                        {
                            id = 3,
                            assignedto = "MILLER William",
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8881),
                            createdby = "Seed Data",
                            number = "#3",
                            title = "Issue 3",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8882),
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

                    b.Property<DateTime?>("createdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<int>("groupid")
                        .HasColumnType("integer");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedate")
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
                            birthdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6636),
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6729),
                            createdby = "Seed Data",
                            firstname = "Marouane",
                            groupid = 1,
                            lastname = "EL MABROUK",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6731),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            birthdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6739),
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6740),
                            createdby = "Seed Data",
                            firstname = "Smith",
                            groupid = 2,
                            lastname = "JOHN",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6742),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            birthdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6743),
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6744),
                            createdby = "Seed Data",
                            firstname = "William",
                            groupid = 3,
                            lastname = "MILLER",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6745),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("createdby")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("updatedate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9852),
                            createdby = "Seed Data",
                            description = "Super Administrator Description",
                            role = 1,
                            title = "Super Administrator",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9860),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9867),
                            createdby = "Seed Data",
                            description = "Administrator Description",
                            role = 2,
                            title = "Administrator",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9869),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9870),
                            createdby = "Seed Data",
                            description = "User Description",
                            role = 3,
                            title = "User",
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9872),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("createdate")
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

                    b.Property<DateTime?>("updatedate")
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
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(903),
                            createdby = "Seed Data",
                            email = "user1@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 1,
                            roleid = 1,
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(912),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1087),
                            createdby = "Seed Data",
                            email = "user2@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 2,
                            roleid = 2,
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1089),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1111),
                            createdby = "Seed Data",
                            email = "user3@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            personid = 3,
                            roleid = 3,
                            updatedate = new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1112),
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
