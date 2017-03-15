using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumePage.Migrations
{
    public partial class JobDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                            name: "Description",
                            columns: table => new
                            {
                                ID = table.Column<int>(nullable: false)
                                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                Summary = table.Column<string>(nullable: false)
                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_Description", x => x.ID);
                            });
           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Description_DescriptionID",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Description",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Description");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionID",
                table: "Description",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ResumePage.Models.Description_DescriptionID",
                table: "Description",
                column: "DescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_ResumePage.Models.Description_DescriptionID",
                table: "Jobs",
                column: "DescriptionID",
                principalTable: "Description",
                principalColumn: "DescriptionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Description",
                newName: "ResumePage.Models.Description");
        }
    }
}
