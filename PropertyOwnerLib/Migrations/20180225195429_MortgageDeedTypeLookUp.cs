using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Database.Migrations
{
    public partial class MortgageDeedTypeLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MortgageDeedType",
                columns: table => new
                {
                    MortgageDeedTypeCode = table.Column<string>(nullable: false),
                    MortgageDeedTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MortgageDeedType", x => x.MortgageDeedTypeCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_MortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "MortgageDeedTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_MortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "MortgageDeedTypeCode",
                principalTable: "MortgageDeedType",
                principalColumn: "MortgageDeedTypeCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_MortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "MortgageDeedType");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_MortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<string>(
                name: "MortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
