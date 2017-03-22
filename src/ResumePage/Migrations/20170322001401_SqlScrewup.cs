using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumePage.Migrations
{
    public partial class SqlScrewup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Jobs_JobIDID",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Jobs_JobsID",
                table: "Peoples");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescriptionID = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(maxLength: 2000, nullable: true),
                    DateJoined = table.Column<DateTime>(nullable: true),
                    DateLeft = table.Column<DateTime>(nullable: true),
                    EndingPay = table.Column<decimal>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    StartingPay = table.Column<decimal>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Description_Description_DescriptionID",
                        column: x => x.DescriptionID,
                        principalTable: "Description",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Description_DescriptionID",
                table: "Description",
                column: "DescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Description_JobIDID",
                table: "Peoples",
                column: "JobIDID",
                principalTable: "Description",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Description_JobsID",
                table: "Peoples",
                column: "JobsID",
                principalTable: "Description",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Description_JobIDID",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Description_JobsID",
                table: "Peoples");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateJoined = table.Column<DateTime>(nullable: false),
                    DateLeft = table.Column<DateTime>(nullable: false),
                    EndingPay = table.Column<decimal>(nullable: false),
                    JobDescription = table.Column<string>(nullable: false),
                    StartingPay = table.Column<decimal>(nullable: false),
                    Summary = table.Column<string>(maxLength: 2000, nullable: true),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Jobs_JobIDID",
                table: "Peoples",
                column: "JobIDID",
                principalTable: "Jobs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Jobs_JobsID",
                table: "Peoples",
                column: "JobsID",
                principalTable: "Jobs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
