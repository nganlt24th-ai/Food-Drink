using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class s11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("e1d37ee7-5d18-401a-aeb1-edeae6c52f9d"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("a4d8906c-c9b4-422f-ba4f-f4bb407969cd"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 43, 22, 238, DateTimeKind.Local).AddTicks(7619));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("a4d8906c-c9b4-422f-ba4f-f4bb407969cd"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("e1d37ee7-5d18-401a-aeb1-edeae6c52f9d"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 21, 20, 37, 37, 583, DateTimeKind.Local).AddTicks(3865));
        }
    }
}
