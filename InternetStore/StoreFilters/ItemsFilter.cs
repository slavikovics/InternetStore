namespace InternetStore;

public static class ItemsFilter
{
    public static List<StoreItem> FilterByName(List<StoreItem> storeItems, string name)
    {
        List<StoreItem> filteredStoreItems = new List<StoreItem>();

        foreach (StoreItem item in storeItems)
        {
            if (item.Name == name)
            {
                filteredStoreItems.Add(item);
            }
        }
        
        return filteredStoreItems;
    }

    public static List<StoreItem> FilterByPrice(List<StoreItem> storeItems, decimal price, bool lowerThan = true)
    {
        List<StoreItem> filteredStoreItems = new List<StoreItem>();

        foreach (StoreItem item in storeItems)
        {
            if (ComparePrices(item.Price, price, lowerThan))
            {
                filteredStoreItems.Add(item);
            }
        }
        
        return filteredStoreItems;
    }

    public static bool ComparePrices(decimal firstPrice, decimal secondPrice, bool lowerThan)
    {
        if (lowerThan)
        {
            return firstPrice <= secondPrice;
        }
        
        return firstPrice >= secondPrice;    
    }
    
    public static bool CheckCollectionsAreTheSame(List<StoreItem> items1, List<StoreItem> items2 )
    {
        foreach (StoreItem item in items1)
        {
            if (!items2.Contains(item)) return false;
        }
        
        return true;
    }
}