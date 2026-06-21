using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models.EF;

namespace Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly FoodContext _dbContext;
        public MenuController(FoodContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetIsComming()
        {
            var items = from p in _dbContext.Menus
                        where p.IsComming == true
                        orderby p.CreatedBy descending
                        select p;
            return Ok(await items.Take(6).Select(i => new { i.Id, i.Picture, i.Title, i.Intro }).ToListAsync());
        }
    }
}
