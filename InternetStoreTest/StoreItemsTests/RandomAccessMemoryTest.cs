using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class RandomAccessMemoryTest
{
    [TestMethod]
    public void TestMethodTestMemorySize()
    {
        RandomAccessMemory item = new RandomAccessMemory("1", 100);

        try
        {
            item.MemorySize = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Memory size cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.MemorySize, 0);
        
        item.MemorySize = 4200;
        Assert.AreEqual(item.MemorySize, 4200);
        
        try
        {
            item.MemorySize = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Memory size is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodMemoryType()
    {
        RandomAccessMemory item = new RandomAccessMemory("1", 100);

        try
        {
            item.MemoryType = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Memory type cannot be empty.");
        }
        Assert.AreEqual(item.MemoryType, "");

        item.MemoryType = "Memory type";
        Assert.AreEqual(item.MemoryType, "Memory type");
        
        try
        {
            item.MemoryType = "New Memory type";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Memory type is already set.");
        }
    }
}