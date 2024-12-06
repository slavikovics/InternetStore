using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class StorageFilterTests
{
    [TestMethod]
    public void TestMethodSortByPrice()
    {
        Storage storage1 = new Storage("1", 1, new decimal(450.6));
        Storage storage2 = new Storage("2", 2, new decimal(350.6));
        Storage storage3 = new Storage("3", 3, new decimal(950.6));
        
        List<Storage> storages = 
        [
            storage1,
            storage2,
            storage3
        ];
            
        StoragesFilter.SortByPrice(storages);
        
        List<Storage> storagesExpectedResult = 
        [
            storage2,
            storage1,
            storage3
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(storages, storagesExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByMemorySize()
    {
        Storage storage1 = new Storage("1", 1, new decimal(450.6));
        Storage storage2 = new Storage("2", 2, new decimal(350.6));
        Storage storage3 = new Storage("3", 3, new decimal(950.6));

        storage1.MemorySize = 2000;
        storage2.MemorySize = 8000;
        storage3.MemorySize = 4000;
        
        List<Storage> storages = 
        [
            storage1,
            storage2,
            storage3
        ];
            
        StoragesFilter.SortByMemorySize(storages);
        
        List<Storage> storagesExpectedResult = 
        [
            storage2,
            storage3,
            storage1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(storages, storagesExpectedResult), true);
    }
}