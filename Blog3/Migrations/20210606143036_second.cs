using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "adfd90fb-3298-4ede-af15-88afccd8bfc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "131898f1-cdcf-4d44-89d1-a0ec93358686", "AQAAAAEAACcQAAAAEEQooxXitStR54iyL2zynbYd+9GaJMQ2huvR0tHyuUKh282fi2LYD64nGgWPCc53uQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5a6f789a-decd-49d7-9c86-cf7e0874af49");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64dd629c-57aa-46b3-8fdf-bddeb6aab780", "AQAAAAEAACcQAAAAENfBT0hu+P3huija4FmdBssqTvhP1owoU36wJRCdiej3bVqTlQY6ePoesLdPCGBUAw==" });
        }
    }
}
