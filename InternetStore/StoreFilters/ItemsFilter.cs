﻿namespace InternetStore;

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

    public static StoreItem FindBestByPrice(List<StoreItem> storeItems)
    {
        if (storeItems.Count == 0) throw new ArgumentException("No store items found.");
        
        decimal bestPrice = storeItems[0].Price;
        StoreItem bestItem = storeItems[0];

        foreach (StoreItem item in storeItems)
        {
            if (item.Price > bestPrice)
            {
                bestPrice = item.Price;
                bestItem = item;
            }
        }
        
        return bestItem;
    }

    public static bool ComparePrices(decimal firstPrice, decimal secondPrice, bool lowerThan)
    {
        if (lowerThan)
        {
            return firstPrice <= secondPrice;
        }
        
        return firstPrice >= secondPrice;    
    }

    public static void SortByPrice(List<StoreItem> storeItems)
    {
        storeItems.Sort();
        return;
    }
    
    public static bool CheckCollectionsHaveTheSameElements<T>(List<T> items1, List<T> items2 )
    {
        foreach (T item in items1)
        {
            if (!items2.Contains(item)) return false;
        }
        
        return true;
    }

    public static bool CheckCollectionsAreEqual<T>(List<T> items1, List<T> items2)
    {
        if (items1.Count != items2.Count) return false;

        for (int i = 0; i < items1.Count; i++)
        {
            if (!items1[i].Equals(items2[i])) return false;
        }
        
        return true;
    }
}