using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class _forHomeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "7437a8e0-f4e0-4f83-b17e-63563af6eb08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d44082e-d72a-4157-a66e-b8974b37b2d4", "AQAAAAEAACcQAAAAEN47XRQUZ/4Cb6y6oJSnckfEaLw66yPZx1Eqf1xvalL5ckywylPzjSQXCvT+Hk6Sdg==" });
        }
    }
}
