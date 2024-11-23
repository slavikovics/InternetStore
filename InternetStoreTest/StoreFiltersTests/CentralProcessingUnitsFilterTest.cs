using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class CentralProcessingUnitsFilterTest
{
    [TestMethod]
    public void TestMethodSortByPrice()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));
        CentralProcessingUnit cpu3 = new CentralProcessingUnit("3", "3", new decimal(950.6));
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
            cpu3
        ];
        
        CentralProcessingUnitsFilter.SortByPrice(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu2,
            cpu1,
            cpu3
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByCoreCount()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));
        CentralProcessingUnit cpu3 = new CentralProcessingUnit("3", "3", new decimal(950.6));

        cpu1.CoreCount = 2;
        cpu2.CoreCount = 16;
        cpu3.CoreCount = 8;
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
            cpu3
        ];
        
        CentralProcessingUnitsFilter.SortByCoreCount(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu2,
            cpu3,
            cpu1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByBaseFrequency()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));
        CentralProcessingUnit cpu3 = new CentralProcessingUnit("3", "3", new decimal(950.6));

        cpu1.BaseFrequency = 2000;
        cpu2.BaseFrequency = 4800;
        cpu3.BaseFrequency = 3500;
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
            cpu3
        ];
        
        CentralProcessingUnitsFilter.SortByBaseFrequency(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu2,
            cpu3,
            cpu1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByMaxFrequency()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));
        CentralProcessingUnit cpu3 = new CentralProcessingUnit("3", "3", new decimal(950.6));

        cpu1.MaxFrequency = 2000;
        cpu2.MaxFrequency = 4800;
        cpu3.MaxFrequency = 3500;
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
            cpu3
        ];
        
        CentralProcessingUnitsFilter.SortByMaxFrequency(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu2,
            cpu3,
            cpu1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortBySupportsMultithreading()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));

        cpu1.SupportsMultithreading = false;
        cpu2.SupportsMultithreading = true;
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
        ];
        
        CentralProcessingUnitsFilter.SortBySupportsMultithreading(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu2,
            cpu1
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
    
    [TestMethod]
    public void TestMethodSortByThermalDesignPower()
    {
        CentralProcessingUnit cpu1 = new CentralProcessingUnit("1", "1", new decimal(450.6));
        CentralProcessingUnit cpu2 = new CentralProcessingUnit("2", "2", new decimal(350.6));
        CentralProcessingUnit cpu3 = new CentralProcessingUnit("3", "3", new decimal(950.6));

        cpu1.ThermalDesignPower = 20;
        cpu2.ThermalDesignPower = 48;
        cpu3.ThermalDesignPower = 35;
        
        List<CentralProcessingUnit> cpus = 
        [
            cpu1,
            cpu2,
            cpu3
        ];
        
        CentralProcessingUnitsFilter.SortByThermalDesignPower(cpus);
        
        List<CentralProcessingUnit> cpusExpectedResult = 
        [
            cpu1,
            cpu3,
            cpu2
        ];
        
        Assert.AreEqual(ItemsFilter.CheckCollectionsAreEqual(cpus, cpusExpectedResult), true);
    }
}