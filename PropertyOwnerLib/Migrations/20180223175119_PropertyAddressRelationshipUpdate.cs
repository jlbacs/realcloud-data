using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class PropertyAddressRelationshipUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey");
        }
    }
}
