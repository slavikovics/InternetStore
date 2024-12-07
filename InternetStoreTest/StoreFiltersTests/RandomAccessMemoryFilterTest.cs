using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class RandomAccessMemoryFilterTest
{
    
    [TestMethod]
    public void TestMethodSortByPrice()
    {
        RandomAccessMemory ram1 = new RandomAccessMemory("1", new decimal(450.6));
        RandomAccessMemory ram2 = new RandomAccessMemory("2", new decimal(350.6));
        RandomAccessMemory ram3 = new RandomAccessMemory("3", new decimal(950.6));
        
        List<RandomAccessMemory> rams = 
        [
            ram1,
            ram2,
            ram3
        ];
            
        RandomAccessMemoryFilter.SortByPrice(rams);
        
        List<RandomAccessMemory> ramsExpectedResult = 
        [
            ram2,
            ram1,
            ram3
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(rams, ramsExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByMemorySize()
    {
        RandomAccessMemory ram1 = new RandomAccessMemory("1", new decimal(450.6));
        RandomAccessMemory ram2 = new RandomAccessMemory("2", new decimal(350.6));
        RandomAccessMemory ram3 = new RandomAccessMemory("3", new decimal(950.6));

        ram1.MemorySize = 2000;
        ram2.MemorySize = 8000;
        ram3.MemorySize = 4000;
        
        List<RandomAccessMemory> rams = 
        [
            ram1,
            ram2,
            ram3
        ];
            
        RandomAccessMemoryFilter.SortByMemorySize(rams);
        
        List<RandomAccessMemory> ramsExpectedResult = 
        [
            ram2,
            ram3,
            ram1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(rams, ramsExpectedResult), true);
    }
}