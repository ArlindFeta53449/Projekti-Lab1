using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studentet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Emaili = table.Column<string>(type: "TEXT", nullable: true),
                    NrLetenjoftimit = table.Column<int>(type: "INTEGER", nullable: false),
                    Emri = table.Column<string>(type: "TEXT", nullable: true),
                    EmriPrindit = table.Column<string>(type: "TEXT", nullable: true),
                    Mbiemri = table.Column<string>(type: "TEXT", nullable: true),
                    Gjinia = table.Column<string>(type: "TEXT", nullable: true),
                    Ditelindja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Vendlindja = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentet");
        }
    }
}
