using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class s6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("edb3a1c8-e6f5-4a46-b876-7ab6c9ca47a7"));

            migrationBuilder.DropColumn(
                name: "Intro",
                table: "New");

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("d0d7b309-5b2c-46f8-a5a4-cb653ffaf448"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 23, 5, 37, 773, DateTimeKind.Local).AddTicks(7960));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("d0d7b309-5b2c-46f8-a5a4-cb653ffaf448"));

            migrationBuilder.AddColumn<string>(
                name: "Intro",
                table: "New",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("edb3a1c8-e6f5-4a46-b876-7ab6c9ca47a7"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 16, 20, 9, 16, 207, DateTimeKind.Local).AddTicks(4567));
        }
    }
}
