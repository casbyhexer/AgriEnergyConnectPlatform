using AgriEnergyConnectPlatform.Data;
using AgriEnergyConnectPlatform.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

[Authorize(Roles = "Farmer")]
public class FarmerController : Controller
{
    private readonly ApplicationDbContext DbContext;
    private readonly UserManager<IdentityUser> _userManager;

    public FarmerController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        DbContext = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var farmer = await DbContext.Farmers.Include(f => f.Products)
            .FirstOrDefaultAsync(f => f.UserId == user.Id);

        return View(farmer);
    }

    [HttpGet]
    public IActionResult AddProduct(Products model)
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct(Farmers model)
    {
        var user = await _userManager.GetUserAsync(User);
        var farmer = await DbContext.Farmers
            .FirstOrDefaultAsync(f => f.UserId == user.Id);

        if (farmer == null)
        {
            return NotFound();
        }

        model.FarmerID = farmer.FarmerID;
        DbContext.Products.Add(model);
        await DbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}
