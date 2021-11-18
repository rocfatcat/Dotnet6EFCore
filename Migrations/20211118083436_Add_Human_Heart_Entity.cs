using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dotnet6EFCore.Migrations
{
    public partial class Add_Human_Heart_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hearts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Heartbeat = table.Column<int>(type: "int", nullable: false),
                    BolldPressure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hearts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hearts_Humans_Id",
                        column: x => x.Id,
                        principalTable: "Humans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hearts");

            migrationBuilder.DropTable(
                name: "Humans");
        }
    }
}
