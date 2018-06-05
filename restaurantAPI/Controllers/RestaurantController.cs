using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using restaurantAPI.Models;

namespace restaurantApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantController : ControllerBase
  {
    private readonly RestaurantContext _context;

    public Restaurant.Controller(RestaurantContext context)
    {
      _context = context;

      if (_context.Restaurants.Count() == 0)
      {
        _context.Restaurants.Add(new Restaurant { Name = "Restaurant1" });
        _context.SaveChanges();
      }
    }

    [HttpGet]
    public ActionResult<List<Restaurant>> GetAll()
    {
      return _context.Restaurants.ToList();
    }

    [HttpGet("{id}", Name = "GetRestaurant")]
    public ActionResult<Restaurant> GetById(long id)
    {
      var item = _context.Restaurants.Find(id);
      if (item == null)
      {
        return NotFound();
      }
      return item;
    }
  }
}