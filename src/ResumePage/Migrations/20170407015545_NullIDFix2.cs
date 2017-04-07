using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePage.Migrations
{
    public partial class NullIDFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Peoples_PeopleId",
                table: "Educations");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Educations",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Peoples_PeopleId",
                table: "Educations",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Peoples_PeopleId",
                table: "Educations");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Educations",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Peoples_PeopleId",
                table: "Educations",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
