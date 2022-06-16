using Microsoft.EntityFrameworkCore.Migrations;

namespace OnePage5.Migrations
{
    public partial class step1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toEats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toEats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "catagories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ToEatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_catagories_toEats_ToEatId",
                        column: x => x.ToEatId,
                        principalTable: "toEats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_catagories_ToEatId",
                table: "catagories",
                column: "ToEatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catagories");

            migrationBuilder.DropTable(
                name: "toEats");
        }
    }
}
