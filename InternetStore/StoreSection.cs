namespace InternetStore;

public class StoreSection
{
    public string Name { get; private set; }
    
    public string Url { get; private set; }
    
    public string Id { get; private set; }

    public List<StoreItem> Items { get; private set; }

    public void AddItem(StoreItem item)
    {
        Items.Add(item);
    }

    public StoreSection(string name, string url, string id)
    {
        Name = name;
        Url = url;
        Id = id;
        Items = new List<StoreItem>();
    }
}