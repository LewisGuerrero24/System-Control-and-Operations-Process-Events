using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class salesDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalePayment_payments_PaymentId",
                table: "SalePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_SalePayment_sales_SaleId",
                table: "SalePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetail_sales_salesId",
                table: "SalesDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesDetail",
                table: "SalesDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalePayment",
                table: "SalePayment");

            migrationBuilder.RenameTable(
                name: "SalesDetail",
                newName: "salesDetails");

            migrationBuilder.RenameTable(
                name: "SalePayment",
                newName: "salesPayment");

            migrationBuilder.RenameIndex(
                name: "IX_SalesDetail_salesId",
                table: "salesDetails",
                newName: "IX_salesDetails_salesId");

            migrationBuilder.RenameIndex(
                name: "IX_SalePayment_SaleId",
                table: "salesPayment",
                newName: "IX_salesPayment_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SalePayment_PaymentId",
                table: "salesPayment",
                newName: "IX_salesPayment_PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesDetails",
                table: "salesDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesPayment",
                table: "salesPayment",
                columns: new[] { "SaleId", "PaymentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_salesDetails_sales_salesId",
                table: "salesDetails",
                column: "salesId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salesPayment_payments_PaymentId",
                table: "salesPayment",
                column: "PaymentId",
                principalTable: "payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_salesPayment_sales_SaleId",
                table: "salesPayment",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesDetails_sales_salesId",
                table: "salesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_salesPayment_payments_PaymentId",
                table: "salesPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_salesPayment_sales_SaleId",
                table: "salesPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesPayment",
                table: "salesPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesDetails",
                table: "salesDetails");

            migrationBuilder.RenameTable(
                name: "salesPayment",
                newName: "SalePayment");

            migrationBuilder.RenameTable(
                name: "salesDetails",
                newName: "SalesDetail");

            migrationBuilder.RenameIndex(
                name: "IX_salesPayment_SaleId",
                table: "SalePayment",
                newName: "IX_SalePayment_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_salesPayment_PaymentId",
                table: "SalePayment",
                newName: "IX_SalePayment_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_salesDetails_salesId",
                table: "SalesDetail",
                newName: "IX_SalesDetail_salesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalePayment",
                table: "SalePayment",
                columns: new[] { "SaleId", "PaymentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesDetail",
                table: "SalesDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalePayment_payments_PaymentId",
                table: "SalePayment",
                column: "PaymentId",
                principalTable: "payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalePayment_sales_SaleId",
                table: "SalePayment",
                column: "SaleId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetail_sales_salesId",
                table: "SalesDetail",
                column: "salesId",
                principalTable: "sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
