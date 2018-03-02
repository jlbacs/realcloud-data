using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Database.Migrations
{
    public partial class MortgageLoanLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MortgageLoan",
                columns: table => new
                {
                    MortgageLoanTypeCode = table.Column<string>(nullable: false),
                    MortgageLoanTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageLoan", x => x.MortgageLoanTypeCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageLoan_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode",
                principalTable: "MortgageLoan",
                principalColumn: "MortgageLoanTypeCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoan_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "MortgageLoan");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<string>(
                name: "MortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
