using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class SEEDUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Businesses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150) CHARACTER SET utf8mb4",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "2537206180");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "2534337926");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                column: "PhoneNumber",
                value: "2533286127");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                column: "PhoneNumber",
                value: "2535651007");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                column: "PhoneNumber",
                value: "2535648853");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                column: "PhoneNumber",
                value: "2537525200");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7,
                column: "PhoneNumber",
                value: "2535376012");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8,
                column: "PhoneNumber",
                value: "2535360514");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9,
                column: "PhoneNumber",
                value: "2535729705");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10,
                column: "PhoneNumber",
                value: "2537615116");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11,
                column: "PhoneNumber",
                value: "2532725600");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 12,
                column: "PhoneNumber",
                value: "2534478740");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 13,
                column: "PhoneNumber",
                value: "2535037161");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 14,
                column: "PhoneNumber",
                value: "2532545052");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 15,
                column: "PhoneNumber",
                value: "2534333279");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 17,
                column: "PhoneNumber",
                value: "2536278152");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 19,
                column: "PhoneNumber",
                value: "2533261354");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 20,
                column: "PhoneNumber",
                value: "2532929194");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 21,
                column: "PhoneNumber",
                value: "2533025296");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 22,
                column: "PhoneNumber",
                value: "2535077289");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 23,
                column: "PhoneNumber",
                value: "2532840523");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 24,
                column: "PhoneNumber",
                value: "2532720112");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 25,
                column: "PhoneNumber",
                value: "2536257843");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 26,
                column: "PhoneNumber",
                value: "2534750933");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 27,
                column: "PhoneNumber",
                value: "2537524863");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 28,
                column: "PhoneNumber",
                value: "2533271791");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 29,
                column: "PhoneNumber",
                value: "(253) 4721975");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 30,
                column: "PhoneNumber",
                value: "2535884191");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 31,
                column: "PhoneNumber",
                value: "(253) 3837277");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Businesses",
                type: "varchar(150) CHARACTER SET utf8mb4",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "(253)-720-6180");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "(253)-433-7926");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                column: "PhoneNumber",
                value: "(253)-328-6127");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                column: "PhoneNumber",
                value: "(253)-565-1007");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                column: "PhoneNumber",
                value: "(253)-564-8853");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                column: "PhoneNumber",
                value: "(253)-752-5200");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7,
                column: "PhoneNumber",
                value: "(253)-537-6012");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8,
                column: "PhoneNumber",
                value: "(253)-536-0514");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9,
                column: "PhoneNumber",
                value: "(253)-572-9705");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10,
                column: "PhoneNumber",
                value: "(253)-761-5116");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11,
                column: "PhoneNumber",
                value: "(253)-272-5600");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 12,
                column: "PhoneNumber",
                value: "(253)-447-8740");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 13,
                column: "PhoneNumber",
                value: "(253)-503-7161");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 14,
                column: "PhoneNumber",
                value: "(253)-254-5052");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 15,
                column: "PhoneNumber",
                value: "(253)-433-3279");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 17,
                column: "PhoneNumber",
                value: "(253)-627-8152");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 19,
                column: "PhoneNumber",
                value: "(253)-326-1354");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 20,
                column: "PhoneNumber",
                value: "(253)-292-9194");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 21,
                column: "PhoneNumber",
                value: "(253)-302-5296");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 22,
                column: "PhoneNumber",
                value: "(253)-507-7289");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 23,
                column: "PhoneNumber",
                value: "(253)-284-0523");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 24,
                column: "PhoneNumber",
                value: "(253)-272-0112");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 25,
                column: "PhoneNumber",
                value: "(253)-625-7843");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 26,
                column: "PhoneNumber",
                value: "(253)-475-0933");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 27,
                column: "PhoneNumber",
                value: "(253)-752-4863");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 28,
                column: "PhoneNumber",
                value: "(253)-327-1791");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 29,
                column: "PhoneNumber",
                value: "(253) 472-1975");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 30,
                column: "PhoneNumber",
                value: "(253)-588-4191");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 31,
                column: "PhoneNumber",
                value: "(253) 383-7277");
        }
    }
}
