using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamiliaRojahnAmaral_Api.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnUrlImage_CatalogoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "CatalogoItems",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "CatalogoItems");
        }
    }
}
