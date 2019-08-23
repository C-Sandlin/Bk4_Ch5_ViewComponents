using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9fdd54b-4435-4b62-b19d-5de43d1172b5", "AQAAAAEAACcQAAAAEPfgRo6MTg1+7ajAd1NVBIqfBm2UK6ykcRv/5NFrsHZSS0idFYWtwEPs0h2cCjntqw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9b8b50d-023c-4aee-a71f-58a3de88e038", "AQAAAAEAACcQAAAAEF6xFBqJnrP0RsWyisTUL22FkuJDoeHsOlojKYHClpAShlq6uJhB6ERZawSUs1hyVg==" });
        }
    }
}
