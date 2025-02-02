using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migracionPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetail_sales_salesId",
                table: "SalesDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesDetail",
                table: "SalesDetail");

            migrationBuilder.RenameTable(
                name: "SalesDetail",
                newName: "salesDetails");

            migrationBuilder.RenameIndex(
                name: "IX_SalesDetail_salesId",
                table: "salesDetails",
                newName: "IX_salesDetails_salesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesDetails",
                table: "salesDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_salesDetails_sales_salesId",
                table: "salesDetails",
                column: "salesId",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesDetails",
                table: "salesDetails");

            migrationBuilder.RenameTable(
                name: "salesDetails",
                newName: "SalesDetail");

            migrationBuilder.RenameIndex(
                name: "IX_salesDetails_salesId",
                table: "SalesDetail",
                newName: "IX_SalesDetail_salesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesDetail",
                table: "SalesDetail",
                column: "Id");

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
