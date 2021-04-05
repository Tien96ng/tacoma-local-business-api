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
          // new Business { BusinessId = 0,  Name = "", Category = "", Address = "", PhoneNumber = "", WebsiteUrl = "" },
          new Business { BusinessId = 1,  Name = "The Art of Crunch", Category = "Bakery", Address = "7104 6th Ave Tacoma WA 98406-1213", PhoneNumber = "2537206180", WebsiteUrl = "http://www.theartofcrunch.com/" },
          new Business { BusinessId = 2,  Name = "The Dancing Goats® Coffee Bar Point Ruston", Category = "Coffee", Address = "5101 Yacht Club Rd, Tacoma WA 98407-3154", PhoneNumber = "2534337926", WebsiteUrl = "http://www.theartofcrunch.com/" },
          new Business { BusinessId = 3,  Name = "The Coffee Oasis.com", Category = "Coffee", Address = "c/o Serra House 6602 S Alaska St Tacoma WA 98408-1323", PhoneNumber = "2533286127", WebsiteUrl = "https://thecoffeeoasis.com/" },
          new Business { BusinessId = 4,  Name = "Narrows Plaza Bowl", Category = "Bowling", Address = "2200 Mildred St W University Place WA 98466-6041", PhoneNumber = "2535651007", WebsiteUrl = "https://www.narrowsplazabowl.com/" },
          new Business { BusinessId = 5,  Name = "Tower Lanes", Category = "Bowling", Address = "6323 6th Ave Tacoma WA 98406", PhoneNumber = "2535648853", WebsiteUrl = "https://www.towerlanes.net/" },
          new Business { BusinessId = 6,  Name = "Chalet Bowl", Category = "Bowling", Address = "3806 N 26th St Tacoma WA 98407", PhoneNumber = "2537525200", WebsiteUrl = "https://www.chaletbowl.com//" },
          new Business { BusinessId = 7,  Name = "Paradise Lanes Entertainment Center", Category = "Bowling", Address = "12505 Pacific Ave S Tacoma WA 98444", PhoneNumber = "2535376012", WebsiteUrl = "https://www.bowlatparadise.com/" },
          new Business { BusinessId = 8,  Name = "Double Dozen Bowling League", Category = "Bowling", Address = "902 129th St Ct E Tacoma WA 98445", PhoneNumber = "2535360514", WebsiteUrl = "" },
          new Business { BusinessId = 9,  Name = "Anthem Coffee & Tea", Category = "Coffee", Address = "1911 Pacific Ave Tacoma WA 98402", PhoneNumber = "2535729705", WebsiteUrl = "https://myanthemcoffee.com/" },
          new Business { BusinessId = 10, Name = "Valhalla Coffee Co.", Category = "Coffee", Address = "3918 6th Ave Tacoma WA 98406", PhoneNumber = "2537615116", WebsiteUrl = "http://www.valhallacoffee.com/" },
          new Business { BusinessId = 11, Name = "Bluebeard Coffee Roasters", Category = "Coffee", Address = "2201 6th Ave Tacoma WA 98403", PhoneNumber = "2532725600", WebsiteUrl = "https://bluebeardcoffee.com/" },
          new Business { BusinessId = 12, Name = "Gravity Coffee", Category = "Coffee", Address = "4918 Center St Tacoma WA 98409", PhoneNumber = "2534478740", WebsiteUrl = "http://gccoffee.com/" },
          new Business { BusinessId = 13, Name = "Manifesto Coffee", Category = "Coffee", Address = "1003 S 11th St Tacoma WA 98405", PhoneNumber = "2535037161", WebsiteUrl = "http://www.manifestocoffeeroasters.com/" },
          new Business { BusinessId = 14, Name = "Cosmonaut Coffee Co", Category = "Coffee", Address = "817 Division Ave Tacoma WA 98403", PhoneNumber = "2532545052", WebsiteUrl = "https://coffeetacoma.com/" },
          new Business { BusinessId = 15, Name = "Olympia Coffee Roasting", Category = "Coffee", Address = "2601 N Proctor St #5225 Tacoma WA 98407", PhoneNumber = "2534333279", WebsiteUrl = "https://www.olympiacoffee.com/pages/proctor-tacoma" },
          new Business { BusinessId = 16, Name = "Coffeezaun Espresso", Category = "Coffee", Address = "4518 N Pearl St Tacoma WA 98407", PhoneNumber = "", WebsiteUrl = "https://www.facebook.com/Coffeezaun/" },
          new Business { BusinessId = 17, Name = "Metro Coffee", Category = "Coffee", Address = "1901 Jefferson Ave # B Tacoma WA 98402", PhoneNumber = "2536278152", WebsiteUrl = "" },
          new Business { BusinessId = 18, Name = "Campfire coffee co.", Category = "Coffee", Address = "Address: 1554 Market St #101, Tacoma, WA 98402", PhoneNumber = "", WebsiteUrl = "https://www.welovecampfire.com/" },
          new Business { BusinessId = 19, Name = "Lift Bridge Coffee", Category = "Coffee", Address = "1102 A St #215 Tacoma WA 98402", PhoneNumber = "2533261354", WebsiteUrl = "https://www.courthousesquaretacoma.com/lift-bridge-coffee" },
          new Business { BusinessId = 20, Name = "Tacoma Java Company", Category = "Coffee", Address = "919 N 2nd St Tacoma WA 98403", PhoneNumber = "2532929194", WebsiteUrl = "http://tacoma-java-company.edan.io/" },
          new Business { BusinessId = 21, Name = "Bostwick Cafe", Category = "Coffee", Address = "764 Broadway Tacoma WA 98402", PhoneNumber = "2533025296", WebsiteUrl = "https://www.bostwickcafe.com/" },
          new Business { BusinessId = 22, Name = "Honey Coffee + Kitchen", Category = "Coffee", Address = "1322 Fawcett Ave Tacoma WA 98402", PhoneNumber = "2535077289", WebsiteUrl = "https://www.almamatertacoma.com/honey-cafe" },
          new Business { BusinessId = 23, Name = "Martin Henry Espresso", Category = "Coffee", Address = "3121 S 38th St Tacoma WA 98409", PhoneNumber = "2532840523", WebsiteUrl = "https://www.martinhenryespresso.com/" },
          new Business { BusinessId = 24, Name = "Hilltop Coffee Bar & Cafe", Category = "Coffee", Address = "1102 S Yakima Ave, Tacoma, WA 98405", PhoneNumber = "2532720112", WebsiteUrl = "https://hilltopcoffeebarcafe.com/" },
          new Business { BusinessId = 25, Name = "Lander Coffee", Category = "Coffee", Address = "2716 N 21st St Tacoma WA 98406", PhoneNumber = "2536257843", WebsiteUrl = "https://www.landercoffee.com//" },
          new Business { BusinessId = 26, Name = "Fox Hollow Coffee Shop", Category = "Coffee", Address = "4020 S 56th St Tacoma WA 98409", PhoneNumber = "2534750933", WebsiteUrl = "http://fox-hollow-coffee-shop.edan.io/" },
          new Business { BusinessId = 27, Name = "Jewel Box Cafe", Category = "Coffee", Address = " 5107 Grand Loop Tacoma WA 98407", PhoneNumber = "2537524863", WebsiteUrl = "https://www.jewelboxcafeatruston.com/" },
          new Business { BusinessId = 28, Name = "Red Elm Cafe", Category = "Coffee", Address = "1114 M.L.K. Jr Way Tacoma WA 98405", PhoneNumber = "2533271791", WebsiteUrl = "https://red-elm-cafe.square.site/" },
          new Business { BusinessId = 29, Name = "Bella Latee", Category = "Coffee", Address = "6450 Tacoma Mall Blvd Tacoma WA 98409", PhoneNumber = "2534721975", WebsiteUrl = "http://bella-latte.edan.io/" },
          new Business { BusinessId = 30, Name = "Coffee Kitchen", Category = "Coffee", Address = "9115 S Tacoma Way Tacoma WA 98499", PhoneNumber = "2535884191", WebsiteUrl = "" },
          new Business { BusinessId = 31, Name = "North Slope Coffee", Category = "Coffee", Address = "618 N 1st St Tacoma, WA 98403", PhoneNumber = "2533837277", WebsiteUrl = "" },
          new Business { BusinessId = 32,  Name = "Corina Bakery", Category = "Bakery", Address = "602 Fawcett Ave Tacoma WA 98402", PhoneNumber = "2536275070", WebsiteUrl = "http://www.corinabakery.com/" },
          new Business { BusinessId = 33,  Name = "Le Donut LLC", Category = "Bakery", Address = "1317 S 11th St Tacoma WA 98405", PhoneNumber = "2536275877", WebsiteUrl = "" },
          new Business { BusinessId = 34,  Name = "Old times bakery", Category = "Bakery", Address = "3514 Pacific Ave Tacoma WA 98418", PhoneNumber = "2536255898", WebsiteUrl = "" }
        );
      builder.Entity<User>()
        .HasData(
          new User { Id = 1, FirstName = "Tien", LastName = "Nguyen", Username = "test", Password = "test" }
      );
    }

     public DbSet<Business> Businesses { get; set; }
     public DbSet<User> Users { get; set; }
  }
}