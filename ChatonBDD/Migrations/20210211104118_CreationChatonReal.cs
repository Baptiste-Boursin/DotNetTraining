using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatonBDD.Migrations
{
    public partial class CreationChatonReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chaton_Categories_CategorieId",
                table: "Chaton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chaton",
                table: "Chaton");

            migrationBuilder.RenameTable(
                name: "Chaton",
                newName: "Chatons");

            migrationBuilder.RenameIndex(
                name: "IX_Chaton_CategorieId",
                table: "Chatons",
                newName: "IX_Chatons_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chatons",
                table: "Chatons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chatons_Categories_CategorieId",
                table: "Chatons",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chatons_Categories_CategorieId",
                table: "Chatons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chatons",
                table: "Chatons");

            migrationBuilder.RenameTable(
                name: "Chatons",
                newName: "Chaton");

            migrationBuilder.RenameIndex(
                name: "IX_Chatons_CategorieId",
                table: "Chaton",
                newName: "IX_Chaton_CategorieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chaton",
                table: "Chaton",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chaton_Categories_CategorieId",
                table: "Chaton",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
