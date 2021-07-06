using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog3.Migrations
{
    public partial class _updateLikes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DislikesCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "DislikesCount",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "2a7bf763-77eb-43eb-ab84-3361935e85f7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5338d7e8-1ca0-4b33-b283-cf3f30922125", "AQAAAAEAACcQAAAAEGsSpVKt81447Po1nPRBpRCqVZRgVVlSvYBPozdiwfgADIkTG36VKQrfeWYRYPk3TQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DislikesCount",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "DislikesCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
