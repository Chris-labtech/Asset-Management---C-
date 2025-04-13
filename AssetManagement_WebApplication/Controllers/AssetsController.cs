using Microsoft.AspNetCore.Mvc;
using AssetManagement_DataBase;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement_WebApplication.Controllers
{

    public class AssetsController : Controller
    {
        private readonly AssetDbContext _dbContext;
        public AssetsController(AssetDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var assets = await _dbContext.Assets.ToListAsync();
            return View(assets);
        }
    }
}
