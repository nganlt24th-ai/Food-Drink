using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class s7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("d0d7b309-5b2c-46f8-a5a4-cb653ffaf448"));

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deatails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deatails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deatails_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deatails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("8ac080b7-f026-4f5c-8fa6-f6d96bf4f7cb"), new Guid("2bd8bd81-f341-438a-98fb-dfad4ffd15bc"), new Guid("5a8afd30-f4e8-4f8d-8519-d27fe14c2eee") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38cd1e1d-d162-40b3-a543-de7fd5398253"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ae4a4f8-b62f-427f-8987-e1caec355c6f"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9eca7eb7-a450-431a-a071-ad472e358a24"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec6a9bf5-545d-4f1a-b288-a0f54d928193"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f4fae31d-33fa-46f5-95d2-5339a77676a7"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3fa3f30-1996-44fc-a68f-941c808e7394"),
                column: "CreatedOn",
                value: new DateTime(2026, 6, 17, 14, 44, 36, 964, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.CreateIndex(
                name: "IX_Deatails_MenuId",
                table: "Deatails",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Deatails_OrderId",
                table: "Deatails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deatails");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("8ac080b7-f026-4f5c-8fa6-f6d96bf4f7cb"));

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
    }
}
