using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamiliaRojahnAmaral_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddValorCatalogoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "CatalogoItems");

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "CatalogoItems",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "CatalogoItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "CatalogoItems",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
