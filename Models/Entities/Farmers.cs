namespace AgriEnergyConnectPlatform.Models.Entities;

public class Farmers
{

    public int FarmerID { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Number { get; set; }
    public List<Products> Products { get; set; }
}
