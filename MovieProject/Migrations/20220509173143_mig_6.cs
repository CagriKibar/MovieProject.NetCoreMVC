using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieProject.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Categories",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MovieId",
                table: "Categories",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Movies_MovieId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_MovieId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Categories");
        }
    }
}
