using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class MotherboardTest
{
    [TestMethod]
    public void TestMethodSocket()
    {
        Motherboard item = new Motherboard("1", 1, 100);

        try
        {
            item.Socket = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Socket cannot be empty.");
        }
        Assert.AreEqual(item.Socket, "");
        
        item.Socket = "Socket";
        Assert.AreEqual(item.Socket, "SOCKET");
        
        try
        {
            item.Socket = "New Socket";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Socket is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodSupportedRandomAccessMemoryType()
    {
        Motherboard item = new Motherboard("1", 1, 100);

        try
        {
            item.SupportedRandomAccessMemoryType = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Supported memory access type cannot be empty.");
        }
        Assert.AreEqual(item.SupportedRandomAccessMemoryType, "");
        
        item.SupportedRandomAccessMemoryType = "name";
        Assert.AreEqual(item.SupportedRandomAccessMemoryType, "name");
        
        try
        {
            item.SupportedRandomAccessMemoryType = "New name";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Supported memory access type is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodChipset()
    {
        Motherboard item = new Motherboard("1", 1, 100);

        try
        {
            item.Chipset = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Chipset cannot be empty.");
        }
        Assert.AreEqual(item.Chipset, "");
      
        item.Chipset = "Chipset";
        Assert.AreEqual(item.Chipset, "Chipset");
        
        try
        {
            item.Chipset = "New Chipset";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Chipset is already set.");
        }
    }
}