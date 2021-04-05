using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class SEED_DATA_AUTH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    Category = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Username = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Category", "Name", "PhoneNumber", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "7104 6th Ave Tacoma WA 98406-1213", "Bakery", "The Art of Crunch", "2537206180", "http://www.theartofcrunch.com/" },
                    { 20, "919 N 2nd St Tacoma WA 98403", "Coffee", "Tacoma Java Company", "2532929194", "http://tacoma-java-company.edan.io/" },
                    { 21, "764 Broadway Tacoma WA 98402", "Coffee", "Bostwick Cafe", "2533025296", "https://www.bostwickcafe.com/" },
                    { 22, "1322 Fawcett Ave Tacoma WA 98402", "Coffee", "Honey Coffee + Kitchen", "2535077289", "https://www.almamatertacoma.com/honey-cafe" },
                    { 23, "3121 S 38th St Tacoma WA 98409", "Coffee", "Martin Henry Espresso", "2532840523", "https://www.martinhenryespresso.com/" },
                    { 24, "1102 S Yakima Ave, Tacoma, WA 98405", "Coffee", "Hilltop Coffee Bar & Cafe", "2532720112", "https://hilltopcoffeebarcafe.com/" },
                    { 25, "2716 N 21st St Tacoma WA 98406", "Coffee", "Lander Coffee", "2536257843", "https://www.landercoffee.com//" },
                    { 19, "1102 A St #215 Tacoma WA 98402", "Coffee", "Lift Bridge Coffee", "2533261354", "https://www.courthousesquaretacoma.com/lift-bridge-coffee" },
                    { 26, "4020 S 56th St Tacoma WA 98409", "Coffee", "Fox Hollow Coffee Shop", "2534750933", "http://fox-hollow-coffee-shop.edan.io/" },
                    { 28, "1114 M.L.K. Jr Way Tacoma WA 98405", "Coffee", "Red Elm Cafe", "2533271791", "https://red-elm-cafe.square.site/" },
                    { 29, "6450 Tacoma Mall Blvd Tacoma WA 98409", "Coffee", "Bella Latee", "2534721975", "http://bella-latte.edan.io/" },
                    { 30, "9115 S Tacoma Way Tacoma WA 98499", "Coffee", "Coffee Kitchen", "2535884191", "" },
                    { 31, "618 N 1st St Tacoma, WA 98403", "Coffee", "North Slope Coffee", "2533837277", "" },
                    { 32, "602 Fawcett Ave Tacoma WA 98402", "Bakery", "Corina Bakery", "2536275070", "http://www.corinabakery.com/" },
                    { 33, "1317 S 11th St Tacoma WA 98405", "Bakery", "Le Donut LLC", "2536275877", "" },
                    { 27, " 5107 Grand Loop Tacoma WA 98407", "Coffee", "Jewel Box Cafe", "2537524863", "https://www.jewelboxcafeatruston.com/" },
                    { 34, "3514 Pacific Ave Tacoma WA 98418", "Bakery", "Old times bakery", "2536255898", "" },
                    { 18, "Address: 1554 Market St #101, Tacoma, WA 98402", "Coffee", "Campfire coffee co.", "", "https://www.welovecampfire.com/" },
                    { 16, "4518 N Pearl St Tacoma WA 98407", "Coffee", "Coffeezaun Espresso", "", "https://www.facebook.com/Coffeezaun/" },
                    { 2, "5101 Yacht Club Rd, Tacoma WA 98407-3154", "Coffee", "The Dancing Goats® Coffee Bar Point Ruston", "2534337926", "http://www.theartofcrunch.com/" },
                    { 3, "c/o Serra House 6602 S Alaska St Tacoma WA 98408-1323", "Coffee", "The Coffee Oasis.com", "2533286127", "https://thecoffeeoasis.com/" },
                    { 4, "2200 Mildred St W University Place WA 98466-6041", "Bowling", "Narrows Plaza Bowl", "2535651007", "https://www.narrowsplazabowl.com/" },
                    { 5, "6323 6th Ave Tacoma WA 98406", "Bowling", "Tower Lanes", "2535648853", "https://www.towerlanes.net/" },
                    { 6, "3806 N 26th St Tacoma WA 98407", "Bowling", "Chalet Bowl", "2537525200", "https://www.chaletbowl.com//" },
                    { 7, "12505 Pacific Ave S Tacoma WA 98444", "Bowling", "Paradise Lanes Entertainment Center", "2535376012", "https://www.bowlatparadise.com/" },
                    { 17, "1901 Jefferson Ave # B Tacoma WA 98402", "Coffee", "Metro Coffee", "2536278152", "" },
                    { 8, "902 129th St Ct E Tacoma WA 98445", "Bowling", "Double Dozen Bowling League", "2535360514", "" },
                    { 10, "3918 6th Ave Tacoma WA 98406", "Coffee", "Valhalla Coffee Co.", "2537615116", "http://www.valhallacoffee.com/" },
                    { 11, "2201 6th Ave Tacoma WA 98403", "Coffee", "Bluebeard Coffee Roasters", "2532725600", "https://bluebeardcoffee.com/" },
                    { 12, "4918 Center St Tacoma WA 98409", "Coffee", "Gravity Coffee", "2534478740", "http://gccoffee.com/" },
                    { 13, "1003 S 11th St Tacoma WA 98405", "Coffee", "Manifesto Coffee", "2535037161", "http://www.manifestocoffeeroasters.com/" },
                    { 14, "817 Division Ave Tacoma WA 98403", "Coffee", "Cosmonaut Coffee Co", "2532545052", "https://coffeetacoma.com/" },
                    { 15, "2601 N Proctor St #5225 Tacoma WA 98407", "Coffee", "Olympia Coffee Roasting", "2534333279", "https://www.olympiacoffee.com/pages/proctor-tacoma" },
                    { 9, "1911 Pacific Ave Tacoma WA 98402", "Coffee", "Anthem Coffee & Tea", "2535729705", "https://myanthemcoffee.com/" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 1, "Tien", "Nguyen", "test", "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
