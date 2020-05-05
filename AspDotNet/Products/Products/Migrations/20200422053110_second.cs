using Microsoft.EntityFrameworkCore.Migrations;

namespace Products.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId1",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId1",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Associations");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Associations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Associations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Associations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId1",
                table: "Associations",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId1",
                table: "Associations",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
