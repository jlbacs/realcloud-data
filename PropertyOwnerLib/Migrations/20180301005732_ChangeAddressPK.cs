using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class ChangeAddressPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_AddressDetails_AddressKey",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_AddressDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails");

            migrationBuilder.RenameColumn(
                name: "AddressKey",
                table: "PropertyDetails",
                newName: "AddressDetailsId");

            migrationBuilder.RenameColumn(
                name: "AddressKey",
                table: "Owner",
                newName: "AddressDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Owner_AddressKey",
                table: "Owner",
                newName: "IX_Owner_AddressDetailsId");

            migrationBuilder.RenameColumn(
                name: "AddressKey",
                table: "AddressDetails",
                newName: "AddressDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressDetailsId",
                table: "PropertyDetails",
                column: "AddressDetailsId",
                unique: true,
                filter: "[AddressDetailsId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_AddressDetails_AddressDetailsId",
                table: "Owner",
                column: "AddressDetailsId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_AddressDetails_AddressDetailsId",
                table: "PropertyDetails",
                column: "AddressDetailsId",
                principalTable: "AddressDetails",
                principalColumn: "AddressDetailsId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_AddressDetails_AddressDetailsId",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_AddressDetails_AddressDetailsId",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_AddressDetailsId",
                table: "PropertyDetails");

            migrationBuilder.RenameColumn(
                name: "AddressDetailsId",
                table: "PropertyDetails",
                newName: "AddressKey");

            migrationBuilder.RenameColumn(
                name: "AddressDetailsId",
                table: "Owner",
                newName: "AddressKey");

            migrationBuilder.RenameIndex(
                name: "IX_Owner_AddressDetailsId",
                table: "Owner",
                newName: "IX_Owner_AddressKey");

            migrationBuilder.RenameColumn(
                name: "AddressDetailsId",
                table: "AddressDetails",
                newName: "AddressKey");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey",
                unique: true,
                filter: "[AddressKey] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_AddressDetails_AddressKey",
                table: "Owner",
                column: "AddressKey",
                principalTable: "AddressDetails",
                principalColumn: "AddressKey",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_AddressDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey",
                principalTable: "AddressDetails",
                principalColumn: "AddressKey",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
