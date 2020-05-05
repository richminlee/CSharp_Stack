using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefDish.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Chefs_ChefId",
                table: "Dishes",
                newName: "ChefId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_Chefs_ChefId",
                table: "Dishes",
                newName: "IX_Dishes_ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "Dishes",
                newName: "Chefs_ChefId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ChefId",
                table: "Dishes",
                newName: "IX_Dishes_Chefs_ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_Chefs_ChefId",
                table: "Dishes",
                column: "Chefs_ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
