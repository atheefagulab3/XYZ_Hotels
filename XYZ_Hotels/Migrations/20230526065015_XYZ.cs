using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XYZ_Hotels.Migrations
{
    /// <inheritdoc />
    public partial class XYZ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalRooms",
                table: "Hotels",
                newName: "Htype");

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Htype",
                table: "Hotels",
                newName: "TotalRooms");

            migrationBuilder.AlterColumn<int>(
                name: "Feedback",
                table: "Hotels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
