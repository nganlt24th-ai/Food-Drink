using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class s4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("ac7caa32-98d1-4d37-abf8-c7a381faa59a"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("eb0f4a58-a1c1-431d-b626-d8d0066afcee"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 13, 16, 2, 47, 571, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CategoryId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("69db046a-0465-45de-994d-0901cd9286bb"), new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"), "delete-group", "Xóa" },
                    { new Guid("927793d2-f9e3-449d-bcf5-851702b8b355"), new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"), "save-group", "Lưu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("eb0f4a58-a1c1-431d-b626-d8d0066afcee"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("69db046a-0465-45de-994d-0901cd9286bb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("927793d2-f9e3-449d-bcf5-851702b8b355"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("ac7caa32-98d1-4d37-abf8-c7a381faa59a"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 12, 23, 33, 52, 840, DateTimeKind.Local).AddTicks(6472));
        }
    }
}
