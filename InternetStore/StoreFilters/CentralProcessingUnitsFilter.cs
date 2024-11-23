namespace InternetStore;

public static class CentralProcessingUnitsFilter
{
    public static void SortByPrice(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.Price;
        }
        
        centralProcessingUnits.Sort();
    }
    
    public static void SortByCoreCount(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.CoreCount;
        }
        
        centralProcessingUnits.Sort();
    }
    
    public static void SortByBaseFrequency(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.BaseFrequency;
        }
        
        centralProcessingUnits.Sort();
    }
    
    public static void SortByMaxFrequency(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.MaxFrequency;
        }
        
        centralProcessingUnits.Sort();
    }
    
    public static void SortBySupportsMultithreading(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.SupportsMultithreading;
        }
        
        centralProcessingUnits.Sort();
    }
    
    public static void SortByThermalDesignPower(List<CentralProcessingUnit> centralProcessingUnits)
    {
        foreach (CentralProcessingUnit cpu in centralProcessingUnits)
        {
            cpu.SortingParameters = CentralProcessingUnitSortingParameters.ThermalDesignPower;
        }
        
        centralProcessingUnits.Sort();
    }
}