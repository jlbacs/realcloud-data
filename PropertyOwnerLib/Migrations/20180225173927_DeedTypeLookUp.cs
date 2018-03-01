using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class DeedTypeLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DeedType",
                columns: table => new
                {
                    DeedTypeCode = table.Column<string>(nullable: false),
                    DeedTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeedType", x => x.DeedTypeCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_DeedTypeCode",
                table: "PropertyDetails",
                column: "DeedTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_DeedType_DeedTypeCode",
                table: "PropertyDetails",
                column: "DeedTypeCode",
                principalTable: "DeedType",
                principalColumn: "DeedTypeCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_DeedType_DeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "DeedType");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_DeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<string>(
                name: "DeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
