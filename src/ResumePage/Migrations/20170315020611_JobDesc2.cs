using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumePage.Migrations
{
    public partial class JobDesc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(name: "DescriptionID", table: "Jobs",  nullable: true);


            migrationBuilder.AddForeignKey(
                    name: "FK_Jobs_Description_DescriptionID",
                    table: "Jobs",
                    column: "DescriptionID",
                    principalTable: "ResumePage.Models.Description",
                    principalColumn: "ID",
                    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "argh",
                table: "Description");
        }
    }
}
