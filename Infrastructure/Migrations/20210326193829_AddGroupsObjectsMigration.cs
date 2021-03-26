using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddGroupsObjectsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "durations",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 322, DateTimeKind.Local).AddTicks(5983), new DateTime(2021, 3, 26, 20, 38, 29, 323, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5443), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5461), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "groups",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5464), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.InsertData(
                table: "groups",
                columns: new[] { "id", "createdate", "createdby", "groupname", "updatedate", "updatedby" },
                values: new object[,]
                {
                    { 12, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5491), "Seed Data", "Group 12", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5492), "Seed Data" },
                    { 11, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5488), "Seed Data", "Group 11", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5489), "Seed Data" },
                    { 4, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5467), "Seed Data", "Group 4", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5468), "Seed Data" },
                    { 9, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5482), "Seed Data", "Group 9", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5483), "Seed Data" },
                    { 8, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5479), "Seed Data", "Group 8", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5481), "Seed Data" },
                    { 7, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5477), "Seed Data", "Group 7", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5478), "Seed Data" },
                    { 6, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5474), "Seed Data", "Group 6", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5475), "Seed Data" },
                    { 5, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5469), "Seed Data", "Group 5", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5471), "Seed Data" },
                    { 10, new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5485), "Seed Data", "Group 10", new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(5487), "Seed Data" }
                });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8862), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8877), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "issues",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8881), new DateTime(2021, 3, 26, 20, 38, 29, 324, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6636), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6729), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6739), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6740), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "birthdate", "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6743), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6744), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9852), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9867), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9870), new DateTime(2021, 3, 26, 20, 38, 29, 326, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(903), new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1087), new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdate", "updatedate" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1111), new DateTime(2021, 3, 26, 20, 38, 29, 329, DateTimeKind.Local).AddTicks(1112) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "groups",
                keyColumn: "id",
                keyValue: 12);

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
    }
}
