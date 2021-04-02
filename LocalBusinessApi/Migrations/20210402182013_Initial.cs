using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: false),
                    Category = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Category", "Name", "PhoneNumber", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "7104 6th Ave Tacoma WA 98406-1213", "Bakery", "The Art of Crunch", "(253)-720-6180", "http://www.theartofcrunch.com/" },
                    { 29, "6450 Tacoma Mall Blvd Tacoma WA 98409", "Coffee", "Bella Latee", "(253) 472-1975", "http://bella-latte.edan.io/" },
                    { 28, "1114 M.L.K. Jr Way Tacoma WA 98405", "Coffee", "Red Elm Cafe", "(253)-327-1791", "https://red-elm-cafe.square.site/" },
                    { 27, " 5107 Grand Loop Tacoma WA 98407", "Coffee", "Jewel Box Cafe", "(253)-752-4863", "https://www.jewelboxcafeatruston.com/" },
                    { 26, "4020 S 56th St Tacoma WA 98409", "Coffee", "Fox Hollow Coffee Shop", "(253)-475-0933", "http://fox-hollow-coffee-shop.edan.io/" },
                    { 25, "2716 N 21st St Tacoma WA 98406", "Coffee", "Lander Coffee", "(253)-625-7843", "https://www.landercoffee.com//" },
                    { 24, "1102 S Yakima Ave, Tacoma, WA 98405", "Coffee", "Hilltop Coffee Bar & Cafe", "(253)-272-0112", "https://hilltopcoffeebarcafe.com/" },
                    { 23, "3121 S 38th St Tacoma WA 98409", "Coffee", "Martin Henry Espresso", "(253)-284-0523", "https://www.martinhenryespresso.com/" },
                    { 22, "1322 Fawcett Ave Tacoma WA 98402", "Coffee", "Honey Coffee + Kitchen", "(253)-507-7289", "https://www.almamatertacoma.com/honey-cafe" },
                    { 21, "764 Broadway Tacoma WA 98402", "Coffee", "Bostwick Cafe", "(253)-302-5296", "https://www.bostwickcafe.com/" },
                    { 20, "919 N 2nd St Tacoma WA 98403", "Coffee", "Tacoma Java Company", "(253)-292-9194", "http://tacoma-java-company.edan.io/" },
                    { 19, "1102 A St #215 Tacoma WA 98402", "Coffee", "Lift Bridge Coffee", "(253)-326-1354", "https://www.courthousesquaretacoma.com/lift-bridge-coffee" },
                    { 18, "Address: 1554 Market St #101, Tacoma, WA 98402", "Coffee", "Campfire coffee co.", "", "https://www.welovecampfire.com/" },
                    { 17, "1901 Jefferson Ave # B Tacoma WA 98402", "Coffee", "Metro Coffee", "(253)-627-8152", "" },
                    { 30, "9115 S Tacoma Way Tacoma WA 98499", "Coffee", "Coffee Kitchen", "(253)-588-4191", "" },
                    { 16, "4518 N Pearl St Tacoma WA 98407", "Coffee", "Coffeezaun Espresso", "", "https://www.facebook.com/Coffeezaun/" },
                    { 14, "817 Division Ave Tacoma WA 98403", "Coffee", "Cosmonaut Coffee Co", "(253)-254-5052", "https://coffeetacoma.com/" },
                    { 13, "1003 S 11th St Tacoma WA 98405", "Coffee", "Manifesto Coffee", "(253)-503-7161", "http://www.manifestocoffeeroasters.com/" },
                    { 12, "4918 Center St Tacoma WA 98409", "Coffee", "Gravity Coffee", "(253)-447-8740", "http://gccoffee.com/" },
                    { 11, "2201 6th Ave Tacoma WA 98403", "Coffee", "Bluebeard Coffee Roasters", "(253)-272-5600", "https://bluebeardcoffee.com/" },
                    { 10, "3918 6th Ave Tacoma WA 98406", "Coffee", "Valhalla Coffee Co.", "(253)-761-5116", "http://www.valhallacoffee.com/" },
                    { 9, "1911 Pacific Ave Tacoma WA 98402", "Coffee", "Anthem Coffee & Tea", "(253)-572-9705", "https://myanthemcoffee.com/" },
                    { 8, "902 129th St Ct E Tacoma WA 98445", "Bowling", "Double Dozen Bowling League", "(253)-536-0514", "" },
                    { 7, "12505 Pacific Ave S Tacoma WA 98444", "Bowling", "Paradise Lanes Entertainment Center", "(253)-537-6012", "https://www.bowlatparadise.com/" },
                    { 6, "3806 N 26th St Tacoma WA 98407", "Bowling", "Chalet Bowl", "(253)-752-5200", "https://www.chaletbowl.com//" },
                    { 5, "6323 6th Ave Tacoma WA 98406", "Bowling", "Tower Lanes", "(253)-564-8853", "https://www.towerlanes.net/" },
                    { 4, "2200 Mildred St W University Place WA 98466-6041", "Bowling", "Narrows Plaza Bowl", "(253)-565-1007", "https://www.narrowsplazabowl.com/" },
                    { 3, "c/o Serra House 6602 S Alaska St Tacoma WA 98408-1323", "Coffee", "The Coffee Oasis.com", "(253)-328-6127", "https://thecoffeeoasis.com/" },
                    { 2, "5101 Yacht Club Rd, Tacoma WA 98407-3154", "Coffee", "The Dancing Goats® Coffee Bar Point Ruston", "(253)-433-7926", "http://www.theartofcrunch.com/" },
                    { 15, "2601 N Proctor St #5225 Tacoma WA 98407", "Coffee", "Olympia Coffee Roasting", "(253)-433-3279", "https://www.olympiacoffee.com/pages/proctor-tacoma" },
                    { 31, "618 N 1st St, Tacoma, WA 98403", "Coffee", "North Slope Coffee", "(253) 383-7277", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
