using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamiliaRojahnAmaral_Api.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnUnidadeAndOrdem_CatalogoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ordem",
                table: "CatalogoItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unidade",
                table: "CatalogoItems",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "CatalogoItems");

            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "CatalogoItems");
        }
    }
}
