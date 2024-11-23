using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class CompatibilityCheckerTest
{
    [TestMethod]
    public void TestMethodCompatibilityCheck()
    {
        CentralProcessingUnit centralProcessingUnit = new CentralProcessingUnit("1", "1", 100);
        Motherboard motherboard = new Motherboard("1", "1", 200);
        RandomAccessMemory randomAccessMemory = new RandomAccessMemory("1", "1", 150);

        centralProcessingUnit.Socket = "AM4";
        motherboard.Socket = "AM4";

        randomAccessMemory.MemoryType = "DDR4";
        motherboard.SupportedRandomAccessMemoryType = "DDR4";
        
        CompatibilityChecker compatibilityChecker = new CompatibilityChecker(centralProcessingUnit, motherboard, randomAccessMemory);
        Assert.AreEqual(compatibilityChecker.CheckSocketCompatibility(), true);
        Assert.AreEqual(compatibilityChecker.CheckMemoryTypeCompatibility(), true);
    }
}