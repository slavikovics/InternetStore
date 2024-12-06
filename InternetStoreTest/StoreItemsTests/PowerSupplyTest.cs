using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class PowerSupplyTest
{
    [TestMethod]
    public void TestMethodDeliveryType()
    {
        PowerSupply item = new PowerSupply("1", 1, 100);
        
        Assert.AreEqual(item.Certificate, PowerSupplyCertificate.None);

        item.Certificate = PowerSupplyCertificate.EightyPlus;
        Assert.AreEqual(item.Certificate, PowerSupplyCertificate.EightyPlus);
        
        try
        {
            item.Certificate = PowerSupplyCertificate.EightyPlusTitanium;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Power supply certificate is already set.");
        }
    }
    
    [TestMethod]
    public void TestMethodWattage()
    {
        PowerSupply item = new PowerSupply("1", 1, 100);

        try
        {
            item.Wattage = 0;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Wattage cannot be less or equal to zero.");
        }
        Assert.AreEqual(item.Wattage, 0);
        
        item.Wattage = 4200;
        Assert.AreEqual(item.Wattage, 4200);
        
        try
        {
            item.Wattage = 5600;
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Wattage is already set.");
        }
    }
}