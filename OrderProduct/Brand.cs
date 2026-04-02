namespace OrderProduct;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CountryOfManufacture { get; set; }
    public bool Licensed { get; set; }

    public Brand(int id, string name, string countryOfManufacture, bool licensed)
    {
        Id = id;
        Name = name;
        CountryOfManufacture = countryOfManufacture;
        Licensed = licensed;
    }
}