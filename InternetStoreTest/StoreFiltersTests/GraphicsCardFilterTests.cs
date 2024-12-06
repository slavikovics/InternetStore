using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class GraphicsCardFilterTests
{
    
    [TestMethod]
    public void TestMethodSortByPrice()
    {
        GraphicsCard gpu1 = new GraphicsCard("1", 1, new decimal(450.6));
        GraphicsCard gpu2 = new GraphicsCard("2", 2, new decimal(350.6));
        GraphicsCard gpu3 = new GraphicsCard("3", 3, new decimal(950.6));
        
        List<GraphicsCard> gpus = 
        [
            gpu1,
            gpu2,
            gpu3
        ];
            
        GraphicsCardsFilter.SortByPrice(gpus);
        
        List<GraphicsCard> gpusExpectedResult = 
        [
            gpu2,
            gpu1,
            gpu3
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(gpus, gpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByVideoMemory()
    {
        GraphicsCard gpu1 = new GraphicsCard("1", 1, new decimal(450.6));
        GraphicsCard gpu2 = new GraphicsCard("2", 2, new decimal(350.6));
        GraphicsCard gpu3 = new GraphicsCard("3", 3, new decimal(950.6));

        gpu1.VideoMemorySize = 2000;
        gpu2.VideoMemorySize = 8000;
        gpu3.VideoMemorySize = 4000;
        
        List<GraphicsCard> gpus = 
        [
            gpu1,
            gpu2,
            gpu3
        ];
            
        GraphicsCardsFilter.SortByVideoMemorySize(gpus);
        
        List<GraphicsCard> gpusExpectedResult = 
        [
            gpu2,
            gpu3,
            gpu1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(gpus, gpusExpectedResult), true);
    }
}