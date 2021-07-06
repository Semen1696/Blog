using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class _Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "966efcbb-9d21-46ed-9e24-465babfe3340");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b923c2ec-c952-4ab5-981c-ece949e7af97", "AQAAAAEAACcQAAAAEAxuJzhCNK1emiZ3DIp6nV2dDmkTX9Kd+TlfrWFIikkIcJba2wFZurU/WBTL51/LLQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
