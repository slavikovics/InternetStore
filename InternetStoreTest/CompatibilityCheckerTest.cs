using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class CompatibilityCheckerTest
{
    [TestMethod]
    public void TestMethodCompatibilityCheck()
    {
        CentralProcessingUnit centralProcessingUnit = new CentralProcessingUnit("1", 1, 100);
        Motherboard motherboard = new Motherboard("1", 1, 200);
        RandomAccessMemory randomAccessMemory = new RandomAccessMemory("1", 1, 150);
        PowerSupply powerSupply = new PowerSupply("1", 180);
        Storage storage = new Storage("1", 1, 270);
        GraphicsCard graphicsCard = new GraphicsCard("1", 1, 800);

        centralProcessingUnit.Socket = "AM4";
        motherboard.Socket = "AM4";

        randomAccessMemory.MemoryType = "DDR4";
        motherboard.SupportedRandomAccessMemoryType = "DDR4";

        powerSupply.Wattage = 500;
        powerSupply.Certificate = PowerSupplyCertificate.EightyPlusBronze;

        graphicsCard.ThermalDesignPower = 280;
        
        CompatibilityChecker compatibilityChecker = new CompatibilityChecker(centralProcessingUnit, motherboard, randomAccessMemory, 
            graphicsCard, storage, powerSupply);
        Assert.AreEqual(compatibilityChecker.CheckSocketCompatibility(), true);
        Assert.AreEqual(compatibilityChecker.CheckMemoryTypeCompatibility(), true);
        Assert.AreEqual(compatibilityChecker.CheckPowerSupplyCompatibility(), true);
    }
}