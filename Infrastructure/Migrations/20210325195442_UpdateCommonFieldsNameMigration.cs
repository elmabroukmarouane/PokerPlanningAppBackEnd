using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdateCommonFieldsNameMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "users",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "users",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "roles",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "roles",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "persons",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "persons",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "issues",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "issues",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "groups",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "groups",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "updatedat",
                table: "durations",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "durations",
                newName: "createdate");

            migrationBuilder.UpdateData(
                table: "durations",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 188, DateTimeKind.Local).AddTicks(463), new DateTime(2021, 3, 25, 20, 54, 42, 190, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6832), new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6864), new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6870), new DateTime(2021, 3, 25, 20, 54, 42, 191, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3131), new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3160), new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3167), new DateTime(2021, 3, 25, 20, 54, 42, 192, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7700), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7895), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7897), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7903), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7905), new DateTime(2021, 3, 25, 20, 54, 42, 195, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4305), new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4341), new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4347), new DateTime(2021, 3, 25, 20, 54, 42, 196, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5063), new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5423), new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5469), new DateTime(2021, 3, 25, 20, 54, 42, 200, DateTimeKind.Local).AddTicks(5472) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "users",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "users",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "roles",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "roles",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "persons",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "persons",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "issues",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "issues",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "groups",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "groups",
                newName: "createdat");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "durations",
                newName: "updatedat");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "durations",
                newName: "createdat");

            migrationBuilder.UpdateData(
                table: "durations",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 332, DateTimeKind.Local).AddTicks(9766), new DateTime(2021, 3, 21, 22, 16, 4, 334, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4640), new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4671), new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4677), new DateTime(2021, 3, 21, 22, 16, 4, 336, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1030), new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1061), new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1067), new DateTime(2021, 3, 21, 22, 16, 4, 337, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "birthdate", "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5119), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5291), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "birthdate", "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5312), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5314), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "birthdate", "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5320), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5322), new DateTime(2021, 3, 21, 22, 16, 4, 340, DateTimeKind.Local).AddTicks(5325) });

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

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2692), new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3059), new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdat", "updatedat" },
                values: new object[] { new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3107), new DateTime(2021, 3, 21, 22, 16, 4, 345, DateTimeKind.Local).AddTicks(3110) });
        }
    }
}
