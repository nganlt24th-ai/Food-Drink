using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class s9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("a982335b-d54b-418d-8634-5318acffc077"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("c787a468-8de5-4ce6-b0ca-b8314b3c4e06"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 18, 0, 12, 564, DateTimeKind.Local).AddTicks(6251));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("c787a468-8de5-4ce6-b0ca-b8314b3c4e06"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("a982335b-d54b-418d-8634-5318acffc077"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 15, 8, 24, 310, DateTimeKind.Local));
        }
    }
}
