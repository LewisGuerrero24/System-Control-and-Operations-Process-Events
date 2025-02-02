using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class typePayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_typePayment_typePaymentId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_typePayment_typePaymentId",
                table: "sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_typePayment",
                table: "typePayment");

            migrationBuilder.RenameTable(
                name: "typePayment",
                newName: "typePayments");

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "salesPayment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "salesPayment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "salesPayment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateBy",
                table: "salesPayment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "salesPayment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_typePayments",
                table: "typePayments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_typePayments_typePaymentId",
                table: "payments",
                column: "typePaymentId",
                principalTable: "typePayments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_typePayments_typePaymentId",
                table: "sales",
                column: "typePaymentId",
                principalTable: "typePayments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_typePayments_typePaymentId",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_typePayments_typePaymentId",
                table: "sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_typePayments",
                table: "typePayments");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "salesPayment");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "salesPayment");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "salesPayment");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "salesPayment");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "salesPayment");

            migrationBuilder.RenameTable(
                name: "typePayments",
                newName: "typePayment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_typePayment",
                table: "typePayment",
                column: "Id");

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
    }
}
