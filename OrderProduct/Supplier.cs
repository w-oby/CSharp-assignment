namespace OrderProduct;

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameOfContact { get; set; }
    public int DurationContractInDays { get; set; }

    public Supplier(int id, string name, string nameOfContact, int durationContractInDays)
    {
        Id = id;
        Name = name;
        NameOfContact = nameOfContact;
        DurationContractInDays = durationContractInDays;
    }

}