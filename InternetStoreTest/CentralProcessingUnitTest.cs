using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class CentralProcessingUnitTest
{
    [TestMethod]
    public void TestMethodTestSocket()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

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
    public void TestMethodModelRow()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.ModelRow = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Model row cannot be empty.");
        }
        Assert.AreEqual(item.ModelRow, "");
        
        item.ModelRow = "ryzen 7";
        Assert.AreEqual(item.ModelRow, "ryzen 7");
        
        try
        {
            item.ModelRow = "New ModelRow";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Model row is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodCoreCount()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.CoreCount = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Core count cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.CoreCount, 0);

        item.CoreCount = 8;
        Assert.AreEqual(item.CoreCount, 8);
        
        try
        {
            item.CoreCount = 16;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Core count is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodDeliveryType()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);
        
        Assert.AreEqual(item.DeliveryType, DeliveryType.None);

        item.DeliveryType = DeliveryType.Box;
        Assert.AreEqual(item.DeliveryType, DeliveryType.Box);
        
        try
        {
            item.DeliveryType = DeliveryType.Multipack;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Delivery type is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodTestCrystalCodeName()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.CrystalCodeName = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Crystal code name cannot be empty.");
        }
        Assert.AreEqual(item.CrystalCodeName, "");
        
        item.CrystalCodeName = "name";
        Assert.AreEqual(item.CrystalCodeName, "name");
        
        try
        {
            item.CrystalCodeName = "New name";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Crystal code name is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodTestBaseFrequency()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.BaseFrequency = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Base frequency cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.BaseFrequency, 0);
        
        item.BaseFrequency = 4200;
        Assert.AreEqual(item.BaseFrequency, 4200);
        
        try
        {
            item.BaseFrequency = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Base frequency is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodTestMaxFrequency()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.MaxFrequency = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Max frequency cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.MaxFrequency, 0);
        
        item.MaxFrequency = 4200;
        Assert.AreEqual(item.MaxFrequency, 4200);
        
        try
        {
            item.MaxFrequency = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Max frequency is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodSupportsMultiThreading()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            bool i = item.SupportsMultithreading;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Multi threading flag was not set.");
        }
        
        item.SupportsMultithreading = true;
        Assert.AreEqual(item.SupportsMultithreading, true);
        
        try
        {
            item.SupportsMultithreading = false;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Supports multi threading flag is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodTestThermalDesignPower()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

        try
        {
            item.ThermalDesignPower = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Thermal design power cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.ThermalDesignPower, 0);
        
        item.ThermalDesignPower = 4200;
        Assert.AreEqual(item.ThermalDesignPower, 4200);
        
        try
        {
            item.ThermalDesignPower = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Thermal design power is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodSupportedRandomAccessMemoryType()
    {
        CentralProcessingUnit item = new CentralProcessingUnit("1", "1", 100);

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
}