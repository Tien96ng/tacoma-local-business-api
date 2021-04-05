using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusiness.Models;
using LocalBusiness.Services;

namespace LocalBusiness.Controllers
{
  
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessContext _db;
    private IUserService _userService;

    public BusinessesController(LocalBusinessContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get(string name, string category, string address, string phoneNumber, string websiteUrl)
    {
      var query = _db.Businesses.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      if (address != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (phoneNumber != null)
      {
        query = query.Where(entry => entry.PhoneNumber == phoneNumber);
      }

      if (websiteUrl != null)
      {
        query = query.Where(entry => entry.WebsiteUrl == websiteUrl);
      }

      return query.ToList();
    }

    // GET: api/businesses/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
        var business = await _db.Businesses.FindAsync(id);

        if (business == null)
        {
            return NotFound();
        }

        return business;
    }

    // PUT: api/businesses/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/businesses
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    // DELETE: api/businesses/5
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
      var response = _userService.Authenticate(model);

      if (response == null)
      return BadRequest(new { message = "Username or password is incorrect" });

      return Ok(response);
    }
  }
}