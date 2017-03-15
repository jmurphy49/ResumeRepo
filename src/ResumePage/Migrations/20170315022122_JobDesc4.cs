using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumePage.Migrations
{
    public partial class JobDesc4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Jobs");

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.ID);
                });

            migrationBuilder.AddColumn<int>(
                name: "DescriptionID",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DescriptionID",
                table: "Jobs",
                column: "DescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobID",
                table: "Jobs",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Description_DescriptionID",
                table: "Jobs",
                column: "DescriptionID",
                principalTable: "Description",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Jobs_JobID",
                table: "Jobs",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
