namespace InternetStore;

public class StoreItem
{
    public string Name { get; private set; }
    
    public string Id { get; private set; }
    
    public decimal Price { get; private set; }

    public StoreItem(string name, string id, decimal price)
    {
        if (price < 0)
        {
            throw new IncorrectStoreItemPriceException();
        }
        
        Name = name;
        Id = id;
        Price = price;
    }
}