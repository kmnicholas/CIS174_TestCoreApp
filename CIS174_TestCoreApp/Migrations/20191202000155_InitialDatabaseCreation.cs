using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations
{
    public partial class InitialDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FamousPeople",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamousPeople", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accomplishment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateOfAccomplishment = table.Column<DateTime>(nullable: false),
                    FamousPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomplishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accomplishment_FamousPeople_FamousPersonId",
                        column: x => x.FamousPersonId,
                        principalTable: "FamousPeople",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accomplishment_FamousPersonId",
                table: "Accomplishment",
                column: "FamousPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accomplishment");

            migrationBuilder.DropTable(
                name: "FamousPeople");
        }
    }
}
