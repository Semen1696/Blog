using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class _update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "3a7d1c87-ce81-4838-baf6-524e821e80fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ddec3a7-1a5e-424f-8730-506b89b76a6b", "AQAAAAEAACcQAAAAEGSoCC8KcXeWwidSSH2ZNcS0/5p0ZUM5bv7cDH57HHOt6r/8h77IfflD9FQanaqTNg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0c6f2d8e-0f81-47b0-94c5-dda63133b9a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4bf8767-bb6a-48fb-85dd-d36d053b3db7", "AQAAAAEAACcQAAAAEJlli1/G/I3YCnk+TDKwe3xtuPFm4XTMIWawKjzjZYftSGR2Ot0HDh03IgWEI/tr4w==" });
        }
    }
}
