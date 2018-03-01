using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class PropertyAddressNullableTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "AddressKey",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey",
                unique: true,
                filter: "[AddressKey] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<int>(
                name: "AddressKey",
                table: "PropertyDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey",
                unique: true);
        }
    }
}
