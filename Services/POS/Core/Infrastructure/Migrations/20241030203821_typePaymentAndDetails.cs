using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class typePaymentAndDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sales_payments_paymentId",
                table: "sales");

            migrationBuilder.DropColumn(
                name: "name",
                table: "payments");

            migrationBuilder.RenameColumn(
                name: "paymentId",
                table: "sales",
                newName: "typePaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_paymentId",
                table: "sales",
                newName: "IX_sales_typePaymentId");

            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "datePayment",
                table: "payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "typePaymentId",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SalesDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salesId = table.Column<int>(type: "int", nullable: false),
                    product = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unitPrice = table.Column<int>(type: "int", nullable: false),
                    subtotal = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesDetail_sales_salesId",
                        column: x => x.salesId,
                        principalTable: "sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "typePayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typePayment", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_payments_saleId",
                table: "payments",
                column: "saleId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_typePaymentId",
                table: "payments",
                column: "typePaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetail_salesId",
                table: "SalesDetail",
                column: "salesId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_sales_saleId",
                table: "payments",
                column: "saleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_typePayment_typePaymentId",
                table: "payments",
                column: "typePaymentId",
                principalTable: "typePayment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_typePayment_typePaymentId",
                table: "sales",
                column: "typePaymentId",
                principalTable: "typePayment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_sales_saleId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_typePayment_typePaymentId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_typePayment_typePaymentId",
                table: "sales");

            migrationBuilder.DropTable(
                name: "SalesDetail");

            migrationBuilder.DropTable(
                name: "typePayment");

            migrationBuilder.DropIndex(
                name: "IX_payments_saleId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_typePaymentId",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "datePayment",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "typePaymentId",
                table: "payments");

            migrationBuilder.RenameColumn(
                name: "typePaymentId",
                table: "sales",
                newName: "paymentId");

            migrationBuilder.RenameIndex(
                name: "IX_sales_typePaymentId",
                table: "sales",
                newName: "IX_sales_paymentId");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_payments_paymentId",
                table: "sales",
                column: "paymentId",
                principalTable: "payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
