using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "The Art of Crunch", Category = "Bakery", Address = "7104 6th Ave Tacoma WA 98406-1213", PhoneNumber = "(253)-720-6180", WebsiteUrl = "http://www.theartofcrunch.com/" },
          new Business { BusinessId = 2, Name = "The Dancing Goats® Coffee Bar Point Ruston", Category = "Coffee", Address = "5101 Yacht Club Rd, Tacoma WA 98407-3154", PhoneNumber = "(253)-433-7926", WebsiteUrl = "http://www.theartofcrunch.com/" },
          new Business { BusinessId = 3, Name = "The Coffee Oasis.com", Category = "Coffee", Address = "c/o Serra House 6602 S Alaska St Tacoma WA 98408-1323", PhoneNumber = "(253)-328-6127", WebsiteUrl = "https://thecoffeeoasis.com/" },
          new Business { BusinessId = 4, Name = "Narrows Plaza Bowl", Category = "Bowling", Address = "2200 Mildred St W University Place WA 98466-6041", PhoneNumber = "(253)-565-1007", WebsiteUrl = "https://www.narrowsplazabowl.com/" },
          new Business { BusinessId = 5, Name = "Tower Lanes", Category = "Bowling", Address = "6323 6th Ave Tacoma WA 98406", PhoneNumber = "(253)-564-8853", WebsiteUrl = "https://www.towerlanes.net/" },
          new Business { BusinessId = 6, Name = "Chalet Bowl", Category = "Bowling", Address = "3806 N 26th St Tacoma WA 98407", PhoneNumber = "(253)-752-5200", WebsiteUrl = "https://www.chaletbowl.com//" },
          new Business { BusinessId = 7, Name = "Paradise Lanes Entertainment Center", Category = "Bowling", Address = "12505 Pacific Ave S Tacoma WA 98444", PhoneNumber = "(253)-537-6012", WebsiteUrl = "https://www.bowlatparadise.com/" },
          new Business { BusinessId = 8, Name = "Double Dozen Bowling League", Category = "Bowling", Address = "902 129th St Ct E Tacoma WA 98445", PhoneNumber = "(253)-536-0514", WebsiteUrl = "" },
          new Business { BusinessId = 9, Name = "Anthem Coffee & Tea", Category = "Coffee", Address = "1911 Pacific Ave Tacoma WA 98402", PhoneNumber = "(253)-572-9705", WebsiteUrl = "https://myanthemcoffee.com/" },
          new Business { BusinessId = 10, Name = "Valhalla Coffee Co.", Category = "Coffee", Address = "3918 6th Ave Tacoma WA 98406", PhoneNumber = "(253)-761-5116", WebsiteUrl = "http://www.valhallacoffee.com/" },
          new Business { BusinessId = 11, Name = "Bluebeard Coffee Roasters", Category = "Coffee", Address = "2201 6th Ave Tacoma WA 98403", PhoneNumber = "(253)-272-5600", WebsiteUrl = "https://bluebeardcoffee.com/" },
          new Business { BusinessId = 12, Name = "Gravity Coffee", Category = "Coffee", Address = "4918 Center St Tacoma WA 98409", PhoneNumber = "(253)-447-8740", WebsiteUrl = "http://gccoffee.com/" },
          new Business { BusinessId = 13, Name = "Manifesto Coffee", Category = "Coffee", Address = "1003 S 11th St Tacoma WA 98405", PhoneNumber = "(253)-503-7161", WebsiteUrl = "http://www.manifestocoffeeroasters.com/" },
          new Business { BusinessId = 14, Name = "Cosmonaut Coffee Co", Category = "Coffee", Address = "817 Division Ave Tacoma WA 98403", PhoneNumber = "(253)-254-5052", WebsiteUrl = "https://coffeetacoma.com/" },
          new Business { BusinessId = 15, Name = "Olympia Coffee Roasting", Category = "Coffee", Address = "2601 N Proctor St #5225 Tacoma WA 98407", PhoneNumber = "(253)-433-3279", WebsiteUrl = "https://www.olympiacoffee.com/pages/proctor-tacoma" },
          new Business { BusinessId = 16, Name = "Coffeezaun Espresso", Category = "Coffee", Address = "4518 N Pearl St Tacoma WA 98407", PhoneNumber = "", WebsiteUrl = "https://www.facebook.com/Coffeezaun/" },
          new Business { BusinessId = 17, Name = "Metro Coffee", Category = "Coffee", Address = "1901 Jefferson Ave # B Tacoma WA 98402", PhoneNumber = "(253)-627-8152", WebsiteUrl = "" },
          new Business { BusinessId = 18, Name = "Campfire coffee co.", Category = "Coffee", Address = "Address: 1554 Market St #101, Tacoma, WA 98402", PhoneNumber = "", WebsiteUrl = "https://www.welovecampfire.com/" },
          new Business { BusinessId = 19, Name = "Lift Bridge Coffee", Category = "Coffee", Address = "1102 A St #215 Tacoma WA 98402", PhoneNumber = "(253)-326-1354", WebsiteUrl = "https://www.courthousesquaretacoma.com/lift-bridge-coffee" },
          new Business { BusinessId = 20, Name = "Tacoma Java Company", Category = "Coffee", Address = "919 N 2nd St Tacoma WA 98403", PhoneNumber = "(253)-292-9194", WebsiteUrl = "http://tacoma-java-company.edan.io/" },
          new Business { BusinessId = 21, Name = "Bostwick Cafe", Category = "Coffee", Address = "764 Broadway Tacoma WA 98402", PhoneNumber = "(253)-302-5296", WebsiteUrl = "https://www.bostwickcafe.com/" },
          new Business { BusinessId = 22, Name = "Honey Coffee + Kitchen", Category = "Coffee", Address = "1322 Fawcett Ave Tacoma WA 98402", PhoneNumber = "(253)-507-7289", WebsiteUrl = "https://www.almamatertacoma.com/honey-cafe" },
          new Business { BusinessId = 23, Name = "Martin Henry Espresso", Category = "Coffee", Address = "3121 S 38th St Tacoma WA 98409", PhoneNumber = "(253)-284-0523", WebsiteUrl = "https://www.martinhenryespresso.com/" },
          new Business { BusinessId = 24, Name = "Hilltop Coffee Bar & Cafe", Category = "Coffee", Address = "1102 S Yakima Ave, Tacoma, WA 98405", PhoneNumber = "(253)-272-0112", WebsiteUrl = "https://hilltopcoffeebarcafe.com/" },
          new Business { BusinessId = 25, Name = "Lander Coffee", Category = "Coffee", Address = "2716 N 21st St Tacoma WA 98406", PhoneNumber = "(253)-625-7843", WebsiteUrl = "https://www.landercoffee.com//" },
          new Business { BusinessId = 26, Name = "Fox Hollow Coffee Shop", Category = "Coffee", Address = "4020 S 56th St Tacoma WA 98409", PhoneNumber = "(253)-475-0933", WebsiteUrl = "http://fox-hollow-coffee-shop.edan.io/" },
          new Business { BusinessId = 27, Name = "Jewel Box Cafe", Category = "Coffee", Address = " 5107 Grand Loop Tacoma WA 98407", PhoneNumber = "(253)-752-4863", WebsiteUrl = "https://www.jewelboxcafeatruston.com/" },
          new Business { BusinessId = 28, Name = "Red Elm Cafe", Category = "Coffee", Address = "1114 M.L.K. Jr Way Tacoma WA 98405", PhoneNumber = "(253)-327-1791", WebsiteUrl = "https://red-elm-cafe.square.site/" },
          new Business { BusinessId = 29, Name = "Bella Latee", Category = "Coffee", Address = "6450 Tacoma Mall Blvd Tacoma WA 98409", PhoneNumber = "(253) 472-1975", WebsiteUrl = "http://bella-latte.edan.io/" },
          new Business { BusinessId = 30, Name = "Coffee Kitchen", Category = "Coffee", Address = "9115 S Tacoma Way Tacoma WA 98499", PhoneNumber = "(253)-588-4191", WebsiteUrl = "" },
          new Business { BusinessId = 31, Name = "North Slope Coffee", Category = "Coffee", Address = "618 N 1st St, Tacoma, WA 98403", PhoneNumber = "(253) 383-7277", WebsiteUrl = "" }
        );
    }

     public DbSet<Business> Businesses { get; set; }
  }
}