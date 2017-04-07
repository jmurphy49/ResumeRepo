using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePage.Migrations
{
    public partial class NullIDFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Peoples_PeopleId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Peoples_PeopleId",
                table: "Jobs",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Peoples_PeopleId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Jobs",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Peoples_PeopleId",
                table: "Jobs",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
