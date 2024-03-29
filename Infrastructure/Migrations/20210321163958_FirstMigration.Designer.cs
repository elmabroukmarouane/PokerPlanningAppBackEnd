﻿// <auto-generated />
using System;
using Infrastructure.Models.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210321163958_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 319, DateTimeKind.Local).AddTicks(8590),
                            createdby = "Seed Data",
                            description = "Super Administrator Description",
                            role = 1,
                            title = "Super Administrator",
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4504),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4837),
                            createdby = "Seed Data",
                            description = "Administrator Description",
                            role = 2,
                            title = "Administrator",
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4844),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4848),
                            createdby = "Seed Data",
                            description = "User Description",
                            role = 3,
                            title = "User",
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4850),
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

                    b.Property<int>("roleid")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("updatedat")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("roleid");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6825),
                            createdby = "Seed Data",
                            email = "user1@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            roleid = 1,
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6846),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 2,
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7130),
                            createdby = "Seed Data",
                            email = "user2@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            roleid = 2,
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7134),
                            updatedby = "Seed Data"
                        },
                        new
                        {
                            id = 3,
                            createdat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7175),
                            createdby = "Seed Data",
                            email = "user3@mail.com",
                            password = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413",
                            roleid = 3,
                            updatedat = new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7178),
                            updatedby = "Seed Data"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.User", b =>
                {
                    b.HasOne("Infrastructure.Models.Classes.Role", "role")
                        .WithMany("users")
                        .HasForeignKey("roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("Infrastructure.Models.Classes.Role", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
