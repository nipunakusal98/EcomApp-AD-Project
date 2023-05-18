using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomApp.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerRAMId",
                table: "ComputerModels");

            migrationBuilder.DropIndex(
                name: "IX_ComputerModels_ComputerRAMId",
                table: "ComputerModels");

            migrationBuilder.DropColumn(
                name: "ComputerRAMId",
                table: "ComputerModels");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_ComputerVGAId",
                table: "ComputerModels",
                column: "ComputerVGAId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerVGAId",
                table: "ComputerModels",
                column: "ComputerVGAId",
                principalTable: "ComputerVGAs",
                principalColumn: "ComputerVGAId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerVGAId",
                table: "ComputerModels");

            migrationBuilder.DropIndex(
                name: "IX_ComputerModels_ComputerVGAId",
                table: "ComputerModels");

            migrationBuilder.AddColumn<int>(
                name: "ComputerRAMId",
                table: "ComputerModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_ComputerRAMId",
                table: "ComputerModels",
                column: "ComputerRAMId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerRAMId",
                table: "ComputerModels",
                column: "ComputerRAMId",
                principalTable: "ComputerVGAs",
                principalColumn: "ComputerVGAId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
