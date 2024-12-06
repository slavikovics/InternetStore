namespace InternetStore;

public class CentralProcessingUnit : StoreItem
{
    public CentralProcessingUnitSortingParameters SortingParameters { get; set; }

    private string? _socket;

    public string Socket
    {
        get => GetSocket(); 
        set => SetSocket(value);
    }
    
    private void SetSocket(string value)
    {
        if (_socket is null && value != "") _socket = value.ToUpper();
        else if (value == "") throw new ArgumentException("Socket cannot be empty.");
        else throw new InvalidOperationException("Socket is already set.");
    }
    
    private string GetSocket()
    {
        if (_socket is null) return "";
        return _socket;
    }

    private string? _modelRow;
    
    public string ModelRow 
    { 
        get => GetModelRow(); 
        set => SetModelRow(value); 
    }
    
    private void SetModelRow(string value)
    {
        if (_modelRow is null && value != "") _modelRow = value;
        else if (value == "") throw new ArgumentException("Model row cannot be empty.");
        else throw new InvalidOperationException("Model row is already set.");
    }
    
    private string GetModelRow()
    {
        if (_modelRow is null) return "";
        return _modelRow;
    }

    private int _coreCount;

    public int CoreCount
    {
        get => GetCoreCount(); 
        set => SetCoreCount(value);
    }
    
    private void SetCoreCount(int value)
    {
        if (_coreCount == 0 && value > 0) _coreCount = value;
        else if (value <= 0) throw new ArgumentException("Core count cannot be less or equal to zero.");
        else throw new InvalidOperationException("Core count is already set.");
    }
    
    private int GetCoreCount()
    {
        return _coreCount;
    }

    private DeliveryType? _deliveryType;
    
    public DeliveryType DeliveryType
    {
        get => GetDeliveryType(); 
        set => SetDeliveryType(value);
    }
    
    private void SetDeliveryType(DeliveryType value)
    {
        if (_deliveryType is null ) _deliveryType = value; 
        else throw new InvalidOperationException("Delivery type is already set.");
    }
    
    private DeliveryType GetDeliveryType()
    {
        if (_deliveryType is null) return DeliveryType.None;
        return _deliveryType.Value;
    }

    private string? _crystalCodeName;

    public string CrystalCodeName
    {
        get => GetCrystalCodeName(); 
        set => SetCrystalCodeName(value);
    }
    
    private void SetCrystalCodeName(string value)
    {
        if (_crystalCodeName is null && value != "") _crystalCodeName = value;
        else if (value == "") throw new ArgumentException("Crystal code name cannot be empty.");
        else throw new InvalidOperationException("Crystal code name is already set.");
    }
    
    private string GetCrystalCodeName()
    {
        if (_crystalCodeName is null) return "";
        return _crystalCodeName;
    }

    private double _baseFrequency;

    public double BaseFrequency
    {
        get => GetBaseFrequency(); 
        set => SetBaseFrequency(value);
    }
    
    private void SetBaseFrequency(double value)
    {
        if (_baseFrequency == 0 && value > 0) _baseFrequency = value;
        else if (value <= 0) throw new ArgumentException("Base frequency cannot be less or equal to zero.");
        else throw new InvalidOperationException("Base frequency is already set.");
    }
    
    private double GetBaseFrequency()
    {
        return _baseFrequency;
    }

    private double _maxFrequency;
    
    public double MaxFrequency
    {
        get => GetMaxFrequency(); 
        set => SetMaxFrequency(value);
    }
    
    private void SetMaxFrequency(double value)
    {
        if (_maxFrequency == 0 && value > 0) _maxFrequency = value;
        else if (value <= 0) throw new ArgumentException("Max frequency cannot be less or equal to zero.");
        else throw new InvalidOperationException("Max frequency is already set.");
    }
    
    private double GetMaxFrequency()
    {
        return _maxFrequency;
    }

    private bool? _supportsMultiThreading;

    public bool SupportsMultithreading
    {
        get => GetSupportsMultiThreading(); 
        set => SetSupportsMultiThreading(value);
    }
    
    private void SetSupportsMultiThreading(bool value)
    {
        if (_supportsMultiThreading is null) _supportsMultiThreading = value;
        else throw new InvalidOperationException("Supports multi threading flag is already set.");
    }
    
    private bool GetSupportsMultiThreading()
    {
        if (_supportsMultiThreading is null) throw new InvalidOperationException("Multi threading flag was not set.");
        return _supportsMultiThreading.Value;
    }

    private double _thermalDesignPower;
    
    public double ThermalDesignPower
    {
        get => GetThermalDesignPower();
        set => SetThermalDesignPower(value);
    }
    
    private void SetThermalDesignPower(double value)
    {
        if (_thermalDesignPower == 0 && value > 0) _thermalDesignPower = value;
        else if (value <= 0) throw new ArgumentException("Thermal design power cannot be less or equal to zero.");
        else throw new InvalidOperationException("Thermal design power is already set.");
    }
    
    private double GetThermalDesignPower()
    {
        return _thermalDesignPower;
    }

    private string? _supportedRandomAccessMemoryType;

    public string SupportedRandomAccessMemoryType
    {
        get => GetSupportedRandomAccessMemoryType();
        set => SetSupportedRandomAccessMemoryType(value);
    }
    
    private void SetSupportedRandomAccessMemoryType(string value)
    {
        if (_supportedRandomAccessMemoryType is null && value != "") _supportedRandomAccessMemoryType = value;
        else if (value == "") throw new ArgumentException("Supported memory access type cannot be empty.");
        else throw new InvalidOperationException("Supported memory access type is already set.");
    }
    
    private string GetSupportedRandomAccessMemoryType()
    {
        if (_supportedRandomAccessMemoryType is null) return "";
        return _supportedRandomAccessMemoryType;
    }

    public override int CompareTo(object obj)
    {
        switch (SortingParameters)
        {
            case CentralProcessingUnitSortingParameters.Price: return ComparerByPrice(obj);
            case CentralProcessingUnitSortingParameters.CoreCount: return ComparerByCoreCount(obj);
            case CentralProcessingUnitSortingParameters.BaseFrequency: return ComparerByBaseFrequency(obj);
            case CentralProcessingUnitSortingParameters.MaxFrequency: return ComparerByMaxFrequency(obj);
            case CentralProcessingUnitSortingParameters.SupportsMultithreading: return ComparerBySupportsMultithreading(obj);
            case CentralProcessingUnitSortingParameters.ThermalDesignPower: return ComparerByThermalDesignPower(obj);
        }
        
        return base.CompareTo(obj);
    }

    private int ComparerByPrice(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (storeItem.Price < Price) return 1;
        if (storeItem.Price == Price) return 0;
        return -1;
    }
    
    private int ComparerByCoreCount(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (storeItem.CoreCount < CoreCount) return -1;
        if (storeItem.CoreCount == CoreCount) return 0;
        return 1;
    }
    
    private int ComparerByBaseFrequency(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (storeItem.BaseFrequency < BaseFrequency) return -1;
        if (Math.Abs(storeItem.BaseFrequency - BaseFrequency) < 0.001) return 0;
        return 1;
    }
    
    private int ComparerByMaxFrequency(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (storeItem.MaxFrequency < MaxFrequency) return -1;
        if (Math.Abs(storeItem.MaxFrequency - MaxFrequency) < 0.001) return 0;
        return 1;
    }
    
    private int ComparerBySupportsMultithreading(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (!storeItem.SupportsMultithreading && SupportsMultithreading) return -1;
        if (storeItem.SupportsMultithreading && SupportsMultithreading || !storeItem.SupportsMultithreading && !SupportsMultithreading) return 0;
        return 1;
    }
    
    private int ComparerByThermalDesignPower(object obj)
    {
        if (obj is not CentralProcessingUnit) throw new ArgumentException("Object is not a CentralProcessingUnit.");
        
        CentralProcessingUnit storeItem = (CentralProcessingUnit)obj;
        if (storeItem.ThermalDesignPower < ThermalDesignPower) return 1;
        if (Math.Abs(storeItem.ThermalDesignPower - ThermalDesignPower) < 0.001) return 0;
        return -1;
    }

    public CentralProcessingUnit(string name, int id, decimal price) : base(name, id, price)
    {
        SortingParameters = CentralProcessingUnitSortingParameters.Price;
    }
}