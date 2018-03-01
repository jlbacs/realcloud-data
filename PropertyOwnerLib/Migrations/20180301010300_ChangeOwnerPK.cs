using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class ChangeOwnerPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyOwner_Owner_OwnerMatchCode",
                table: "PropertyOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owner",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "OwnerMatchCode",
                table: "PropertyOwner");

            migrationBuilder.DropColumn(
                name: "OwnerMatchCode",
                table: "Owner");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "PropertyOwner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Owner",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner",
                columns: new[] { "OwnerId", "PropertyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owner",
                table: "Owner",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyOwner_Owner_OwnerId",
                table: "PropertyOwner",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyOwner_Owner_OwnerId",
                table: "PropertyOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owner",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "PropertyOwner");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Owner");

            migrationBuilder.AddColumn<string>(
                name: "OwnerMatchCode",
                table: "PropertyOwner",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerMatchCode",
                table: "Owner",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner",
                columns: new[] { "OwnerMatchCode", "PropertyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owner",
                table: "Owner",
                column: "OwnerMatchCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyOwner_Owner_OwnerMatchCode",
                table: "PropertyOwner",
                column: "OwnerMatchCode",
                principalTable: "Owner",
                principalColumn: "OwnerMatchCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
