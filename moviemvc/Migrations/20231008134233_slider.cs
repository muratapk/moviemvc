using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviemvc.Migrations
{
    public partial class slider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heading1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Heading2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
