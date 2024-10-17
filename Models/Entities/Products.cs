namespace AgriEnergyConnectPlatform.Models.Entities;

public class Products
{
    

    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int FarmerID { get; set; }
    public Farmers Farmers { get; set; }
}
