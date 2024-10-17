using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnectPlatform.Data;
using AgriEnergyConnectPlatform.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

[Authorize(Roles = "Employee")]
public class EmployeeController : Controller
{
    private readonly ApplicationDbContext DbContext;

    public EmployeeController(ApplicationDbContext DbContext)
    {
        this.DbContext = DbContext;
    }

    public async Task<IActionResult> Index()
    {
        var farmers = await DbContext.Farmer.Include(f => f.Products).ToListAsync();
        return View(farmers);
    }

    [HttpGet]
    public IActionResult AddFarmer()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddFarmer(Farmers model)
    {
        DbContext.Farmer.Add(model);
        await DbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> ViewFarmerProducts(int farmerId)
    {
        var farmer = await DbContext.Farmer.Include(f => f.Products)
            .FirstOrDefaultAsync(f => f.FarmerID == farmerId);

        if (farmer == null)
        {
            return NotFound();
        }

        return View(farmer);
    }

    [HttpGet]
    public IActionResult SearchProducts(string searchTerm)
    {
        var products = DbContext.Products
            .Where(p => p.Name.Contains(searchTerm))
            .ToList();

        return View(products);
    }
}
