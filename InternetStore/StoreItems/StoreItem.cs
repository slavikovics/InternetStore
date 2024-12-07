namespace InternetStore;

public class StoreItem : IComparable
{
    public string Name { get; private set; }
    
    public int Id { get; private set; }
    
    public decimal Price { get; private set; }
    
    private string? _manufacturer;
    
    public string Manufacturer
    {
        get => GetManufacturer();
        set => SetManufacturer(value);
    }

    private void SetManufacturer(string value)
    {
        if (_manufacturer is null && value != "") _manufacturer = value;
        else if (value == "") throw new ArgumentException("Manufacturer cannot be empty.");
        else throw new InvalidOperationException("Manufacturer is already set.");
    }

    private string GetManufacturer()
    {
        if (_manufacturer is null) return "";
        return _manufacturer;
    }

    public StoreItem(string name, decimal price)
    {
        if (price < 0)
        {
            throw new IncorrectStoreItemPriceException();
        }
        
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        string response = $"{Id}. {Name} Price: {Price} ";
        if (_manufacturer is not null) response += $"Manufacturer: {_manufacturer}";
        return response;
    }

    public virtual int CompareTo(object obj)
    {
        if (obj is not StoreItem) throw new ArgumentException("Object is not a StoreItem.");
        
        StoreItem storeItem = (StoreItem)obj;
        if (storeItem.Price < Price) return 1;
        if (storeItem.Price == Price) return 0;
        return -1;
    }
}