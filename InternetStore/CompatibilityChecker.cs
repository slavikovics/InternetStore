namespace InternetStore;

public class CompatibilityChecker
{
    public CentralProcessingUnit CentralProcessingUnit { get; private set; }
    
    public Motherboard Motherboard { get; private set; }
    
    public RandomAccessMemory RandomAccessMemory { get; private set; }

    public bool CheckSocketCompatibility()
    {
        if (Motherboard.Socket != CentralProcessingUnit.Socket) return false;
        return true;
    }

    public bool CheckMemoryTypeCompatibility()
    {
        if (RandomAccessMemory.MemoryType != Motherboard.SupportedRandomAccessMemoryType) return false;
        return true;
    }

    public CompatibilityChecker(CentralProcessingUnit centralProcessingUnit, Motherboard motherboard, RandomAccessMemory randomAccessMemory)
    {
        CentralProcessingUnit = centralProcessingUnit;
        Motherboard = motherboard;
        RandomAccessMemory = randomAccessMemory;
    }
}