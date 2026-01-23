using HotelMgm.Data;
using HotelMgm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelMgm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewCategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public ReviewCategoriesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewCategory>>> GetReviewCategories()
        {
            return await _context.ReviewCategories.ToListAsync();
        }
    }
}
