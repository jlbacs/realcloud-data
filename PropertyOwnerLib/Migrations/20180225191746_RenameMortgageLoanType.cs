using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class RenameMortgageLoanType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoan_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "MortgageLoan");

            migrationBuilder.CreateTable(
                name: "MortgageLoanType",
                columns: table => new
                {
                    MortgageLoanTypeCode = table.Column<string>(nullable: false),
                    MortgageLoanTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageLoanType", x => x.MortgageLoanTypeCode);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode",
                principalTable: "MortgageLoanType",
                principalColumn: "MortgageLoanTypeCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "MortgageLoanType");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageLoan_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode",
                principalTable: "MortgageLoan",
                principalColumn: "MortgageLoanTypeCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
