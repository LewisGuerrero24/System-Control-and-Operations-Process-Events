using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class salesRelationsandPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_sales_saleId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_saleId",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "saleId",
                table: "payments");

            migrationBuilder.CreateTable(
                name: "SalePayment",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    LinkedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePayment", x => new { x.SaleId, x.PaymentId });
                    table.ForeignKey(
                        name: "FK_SalePayment_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalePayment_sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalePayment_PaymentId",
                table: "SalePayment",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalePayment_SaleId",
                table: "SalePayment",
                column: "SaleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalePayment");

            migrationBuilder.AddColumn<int>(
                name: "saleId",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_payments_saleId",
                table: "payments",
                column: "saleId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_sales_saleId",
                table: "payments",
                column: "saleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
