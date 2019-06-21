using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Crudelicious.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
// Other using statements
namespace Crudelicious.Controllers
{
    public class CrudeliciousController : Controller
    {
        private CrudeliciousContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public CrudeliciousController(CrudeliciousContext context)
        {
            dbContext = context;
        }
     
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            
            return View();
        }

        
    }
 }