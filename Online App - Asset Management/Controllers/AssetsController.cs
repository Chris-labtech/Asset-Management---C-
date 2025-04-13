using Microsoft.AspNetCore.Mvc;
using AssetManagement_DataBase;
using AssetManagement_CommonLibrary;
using Microsoft.EntityFrameworkCore;


namespace Online_App___Asset_Management.Controllers
{
    
    public class AssetsController : Controller
    {
        private readonly AssetDbContext _context;

        public AssetsController(AssetDbContext context)
        {
            _context = context;
        }

        // To view a list of all Assets
        public async Task<IActionResult> Index()
        {
            var assets = await _context.Assets.ToListAsync();
            return View(assets);
        }
    }
}
