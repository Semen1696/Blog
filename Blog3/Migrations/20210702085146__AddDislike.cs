using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class _AddDislike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DislikesCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Dislike",
                table: "Likes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Like",
                table: "Likes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "688283de-dcf8-4efb-a2e7-3c9a4f33738c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "170ae3e0-7dcd-4804-9af1-eeaba04adecc", "AQAAAAEAACcQAAAAEKM0eHKtRPmiQJz27NnFvfUIgbOP7SI0bDR0Ncs8r4/NHvuTvTFp/JlW4CTRrI2ZNw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DislikesCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Dislike",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "Likes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a3ba0040-595b-4e3b-b7c0-4834e3fc5ffb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7aaf1e63-2ff3-4f7c-81df-aea6c3f7daef", "AQAAAAEAACcQAAAAEJGgcdtR0mX2HjGOKHJcQ0QuwVRl3AcZXx+zMMnCZfmDQkHU56y8mq6AeX5eyUftLQ==" });
        }
    }
}
