namespace InternetStore;

public class StoragesFilter
{
    public static void SortByPrice(List<Storage> storages)
    {
        foreach (Storage storage in storages)
        {
            storage.SortingParameters = StorageSortingParameters.Price;
        }
        
        storages.Sort();
    }
    
    public static void SortByMemorySize(List<Storage> storages)
    {
        foreach (Storage storage in storages)
        {
            storage.SortingParameters = StorageSortingParameters.MemorySize;
        }
        
        storages.Sort();
    }
}