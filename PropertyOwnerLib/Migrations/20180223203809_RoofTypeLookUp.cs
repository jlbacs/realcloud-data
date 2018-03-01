using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class RoofTypeLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoofTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "RoofType",
                columns: table => new
                {
                    RoofTypeCode = table.Column<string>(nullable: false),
                    RoofTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoofType", x => x.RoofTypeCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_RoofTypeCode",
                table: "PropertyDetails",
                column: "RoofTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_RoofType_RoofTypeCode",
                table: "PropertyDetails",
                column: "RoofTypeCode",
                principalTable: "RoofType",
                principalColumn: "RoofTypeCode",
                onDelete: ReferentialAction.Restrict);            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_RoofType_RoofTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "RoofType");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_RoofTypeCode",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<string>(
                name: "RoofTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
