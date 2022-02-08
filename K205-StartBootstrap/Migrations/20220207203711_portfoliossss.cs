using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K205StartBootstrap.Migrations
{
    public partial class portfoliossss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Portfolios");
        }
    }
}
