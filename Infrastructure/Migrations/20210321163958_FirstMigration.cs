using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role = table.Column<int>(type: "integer", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    roleid = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_roles_roleid",
                        column: x => x.roleid,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "createdat", "createdby", "description", "role", "title", "updatedat", "updatedby" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 21, 17, 39, 58, 319, DateTimeKind.Local).AddTicks(8590), "Seed Data", "Super Administrator Description", 1, "Super Administrator", new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4504), "Seed Data" },
                    { 2, new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4837), "Seed Data", "Administrator Description", 2, "Administrator", new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4844), "Seed Data" },
                    { 3, new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4848), "Seed Data", "User Description", 3, "User", new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4850), "Seed Data" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "createdat", "createdby", "email", "password", "roleid", "updatedat", "updatedby" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6825), "Seed Data", "user1@mail.com", "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413", 1, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6846), "Seed Data" },
                    { 2, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7130), "Seed Data", "user2@mail.com", "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413", 2, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7134), "Seed Data" },
                    { 3, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7175), "Seed Data", "user3@mail.com", "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413", 3, new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7178), "Seed Data" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_roleid",
                table: "users",
                column: "roleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
