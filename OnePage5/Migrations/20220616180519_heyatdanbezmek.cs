using Microsoft.EntityFrameworkCore.Migrations;

namespace OnePage5.Migrations
{
    public partial class heyatdanbezmek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_catagories_toEat_ToEatId",
                table: "catagories");

            migrationBuilder.DropIndex(
                name: "IX_catagories_ToEatId",
                table: "catagories");

            migrationBuilder.DropColumn(
                name: "ToEatId",
                table: "catagories");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "toEat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_toEat_CatagoryId",
                table: "toEat",
                column: "CatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_toEat_catagories_CatagoryId",
                table: "toEat",
                column: "CatagoryId",
                principalTable: "catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_toEat_catagories_CatagoryId",
                table: "toEat");

            migrationBuilder.DropIndex(
                name: "IX_toEat_CatagoryId",
                table: "toEat");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "toEat");

            migrationBuilder.AddColumn<int>(
                name: "ToEatId",
                table: "catagories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_catagories_ToEatId",
                table: "catagories",
                column: "ToEatId");

            migrationBuilder.AddForeignKey(
                name: "FK_catagories_toEat_ToEatId",
                table: "catagories",
                column: "ToEatId",
                principalTable: "toEat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
