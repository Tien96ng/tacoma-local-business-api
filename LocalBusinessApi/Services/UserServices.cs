using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using LocalBusiness.Helpers;
using LocalBusiness.Models;
using LocalBusiness.Interfaces;

namespace LocalBusiness.Services
{
  public class UserService : IUserService
  {
    private readonly LocalBusinessContext _db;

    private readonly AppSettings _appSettings;

    public UserService(IOptions<AppSettings> appSettings, LocalBusinessContext db)
    {
      _appSettings = appSettings.Value;
      _db = db;
    }

    public AuthenticateResponse Authenticate(AuthenticateRequest model)
    {
      var user = _db.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
      Console.WriteLine("USERNAME: " + user.FirstName);

      // return null if user not found
      if (user == null) 
      {
        return null;
      }

      // authentication successful so generate jwt token
      var token = generateJwtToken(user);

      return new AuthenticateResponse(user, token);
    }

    public IEnumerable<User> GetAll()
    {
      return _db.Users;
    }

    public User GetById(int id)
    {
      return _db.Users.FirstOrDefault(x => x.Id == id);
    }

    // helper methods

    private string generateJwtToken(User user)  
    {
      // generate token that is valid for 7 days
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
        Expires = DateTime.UtcNow.AddHours(2),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}