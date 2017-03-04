using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePage.Migrations
{
    public partial class PeopleContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Job_JobIDID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Job_JobsID",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peoples",
                table: "People",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Job",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Education",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Jobs_JobIDID",
                table: "People",
                column: "JobIDID",
                principalTable: "Job",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Jobs_JobsID",
                table: "People",
                column: "JobsID",
                principalTable: "Job",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_People_JobsID",
                table: "People",
                newName: "IX_Peoples_JobsID");

            migrationBuilder.RenameIndex(
                name: "IX_People_JobIDID",
                table: "People",
                newName: "IX_Peoples_JobIDID");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Peoples");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "Jobs");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Jobs_JobIDID",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Jobs_JobsID",
                table: "Peoples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "Peoples",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Jobs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Educations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Job_JobIDID",
                table: "Peoples",
                column: "JobIDID",
                principalTable: "Jobs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Job_JobsID",
                table: "Peoples",
                column: "JobsID",
                principalTable: "Jobs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_JobsID",
                table: "Peoples",
                newName: "IX_People_JobsID");

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_JobIDID",
                table: "Peoples",
                newName: "IX_People_JobIDID");

            migrationBuilder.RenameTable(
                name: "Peoples",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Job");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");
        }
    }
}
