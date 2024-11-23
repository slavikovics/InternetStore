namespace InternetStore;

public class CompatibilityChecker
{
    public CentralProcessingUnit CentralProcessingUnit { get; private set; }
    
    public Motherboard Motherboard { get; private set; }
    
    public RandomAccessMemory RandomAccessMemory { get; private set; }
    
    public Storage Storage { get; private set; }
    
    public GraphicsCard GraphicsCard { get; private set; }
    
    public PowerSupply PowerSupply { get; private set; }

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

    public bool CheckPowerSupplyCompatibility()
    {
        if (PowerSupply.CalculateRealWattage() < GraphicsCard.ThermalDesignPower + CentralProcessingUnit.ThermalDesignPower) return false;
        return true;
    }

    public CompatibilityChecker(CentralProcessingUnit centralProcessingUnit, Motherboard motherboard, RandomAccessMemory randomAccessMemory, 
        GraphicsCard graphicsCard, Storage storage, PowerSupply powerSupply)
    {
        CentralProcessingUnit = centralProcessingUnit;
        Motherboard = motherboard;
        RandomAccessMemory = randomAccessMemory;
        GraphicsCard = graphicsCard;
        Storage = storage;
        PowerSupply = powerSupply;
    }
}