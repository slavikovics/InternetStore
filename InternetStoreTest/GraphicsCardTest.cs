using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class GraphicsCardTest
{
    [TestMethod]
    public void TestMethodVideoMemoryType()
    {
        GraphicsCard item = new GraphicsCard("1", "1", 100);

        try
        {
            item.VideoMemoryType = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Video memory type cannot be empty.");
        }
        Assert.AreEqual(item.VideoMemoryType, "");

        item.VideoMemoryType = "Video memory type";
        Assert.AreEqual(item.VideoMemoryType, "Video memory type");
        
        try
        {
            item.VideoMemoryType = "New Video memory type";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Video memory type is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodGraphicsProcessorName()
    {
        GraphicsCard item = new GraphicsCard("1", "1", 100);

        try
        {
            item.GraphicsProcessorName = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Graphics processor name cannot be empty.");
        }
        Assert.AreEqual(item.GraphicsProcessorName, "");

        item.GraphicsProcessorName = "Graphics processor name";
        Assert.AreEqual(item.GraphicsProcessorName, "Graphics processor name");
        
        try
        {
            item.GraphicsProcessorName = "New Graphics processor name";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Graphics processor name is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodTestVideoMemorySize()
    {
        GraphicsCard item = new GraphicsCard("1", "1", 100);

        try
        {
            item.VideoMemorySize = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Video memory size cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.VideoMemorySize, 0);
        
        item.VideoMemorySize = 4200;
        Assert.AreEqual(item.VideoMemorySize, 4200);
        
        try
        {
            item.VideoMemorySize = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Video memory size is already set.");
        }
    }
}