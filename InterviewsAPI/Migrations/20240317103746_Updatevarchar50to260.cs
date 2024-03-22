using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Updatevarchar50to260 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Option4",
                table: "Questions",
                type: "varchar(260)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Option3",
                table: "Questions",
                type: "varchar(260)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "varchar(260)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "varchar(260)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Questions",
                type: "varchar(260)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Option4",
                table: "Questions",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(260)");

            migrationBuilder.AlterColumn<string>(
                name: "Option3",
                table: "Questions",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(260)");

            migrationBuilder.AlterColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(260)");

            migrationBuilder.AlterColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(260)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Questions",
                type: "varchar(300)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(260)",
                oldNullable: true);
        }
    }
}
