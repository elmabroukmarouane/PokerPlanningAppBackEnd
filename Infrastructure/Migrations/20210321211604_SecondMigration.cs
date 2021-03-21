using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "personid",
                table: "users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "durations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_durations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    groupname = table.Column<string>(type: "text", nullable: true),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "issues",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true),
                    assignedto = table.Column<string>(type: "text", nullable: true),
                    weight = table.Column<int>(type: "integer", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    groupid = table.Column<int>(type: "integer", nullable: false),
                    firstname = table.Column<string>(type: "text", nullable: true),
                    lastname = table.Column<string>(type: "text", nullable: true),
                    birthdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    createdat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    updatedat = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    updatedby = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.id);
                    table.ForeignKey(
                        name: "FK_persons_groups_groupid",
                        column: x => x.groupid,
                        principalTable: "groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "durations",
                columns: new[] { "id", "createdat", "createdby", "duration", "updatedat", "updatedby" },
                values: new object[] { 1, new DateTime(2021, 3, 21, 22, 16, 4, 332, DateTimeKind.Local).AddTicks(9766), "Seed Data", 60, new DateTime(2021, 3, 21, 22, 16, 4, 334, DateTimeKind.Local).AddTicks(8325), "Seed Data" });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "id", "createdat", "createdby", "groupname", "updatedat", "updatedby" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4640), "Seed Data", "Group 1", new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4657), "Seed Data" },
                    { 2, new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4671), "Seed Data", "Group 2", new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4674), "Seed Data" },
                    { 3, new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4677), "Seed Data", "Group 3", new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4680), "Seed Data" }
                });

            migrationBuilder.InsertData(
                table: "issues",
                columns: new[] { "id", "assignedto", "createdat", "createdby", "number", "title", "updatedat", "updatedby", "url", "weight" },
                values: new object[,]
                {
                    { 1, "EL MABROUK Marouane", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1030), "Seed Data", "#1", "Issue 1", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1047), "Seed Data", "https://google.com/", 4 },
                    { 2, "JOHN Smith", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1061), "Seed Data", "#2", "Issue 2", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1064), "Seed Data", "https://google.com/", 4 },
                    { 3, "MILLER William", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1067), "Seed Data", "#3", "Issue 3", new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1070), "Seed Data", "https://google.com/", 4 }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1396), new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1426), new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1432), new DateTime(2021, 3, 21, 22, 16, 4, 341, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "birthdate", "createdat", "createdby", "firstname", "groupid", "lastname", "updatedat", "updatedby" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5119), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5291), "Seed Data", "Marouane", 1, "EL MABROUK", new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5297), "Seed Data" },
                    { 2, new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5312), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5314), "Seed Data", "Smith", 2, "JOHN", new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5317), "Seed Data" },
                    { 3, new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5320), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5322), "Seed Data", "William", 3, "MILLER", new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5325), "Seed Data" }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "personid", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2692), 1, new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "personid", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3059), 2, new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "personid", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3107), 3, new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.CreateIndex(
                name: "IX_users_personid",
                table: "users",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_persons_groupid",
                table: "persons",
                column: "groupid");

            migrationBuilder.AddForeignKey(
                name: "FK_users_persons_personid",
                table: "users",
                column: "personid",
                principalTable: "persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_persons_personid",
                table: "users");

            migrationBuilder.DropTable(
                name: "durations");

            migrationBuilder.DropTable(
                name: "issues");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropIndex(
                name: "IX_users_personid",
                table: "users");

            migrationBuilder.DropColumn(
                name: "personid",
                table: "users");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 319, DateTimeKind.Local).AddTicks(8590), new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4837), new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4848), new DateTime(2021, 3, 21, 17, 39, 58, 321, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6825), new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7130), new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7175), new DateTime(2021, 3, 21, 17, 39, 58, 328, DateTimeKind.Local).AddTicks(7178) });
        }
    }
}
