namespace InternetStore;

public class Storage : StoreItem
{
    public StorageSortingParameters SortingParameters { get; set; }
    
    private string? _memoryType;

    public string MemoryType
    {
        get => GetMemoryType();
        set => SetMemoryType(value);
    }
    
    private void SetMemoryType(string value)
    {
        if (_memoryType is null && value != "") _memoryType = value;
        else if (value == "") throw new ArgumentException("Memory type cannot be empty.");
        else throw new InvalidOperationException("Memory type is already set.");
    }
    
    private string GetMemoryType()
    {
        if (_memoryType is null) return "";
        return _memoryType;
    }
    
    private double _memorySize;
    
    public double MemorySize
    {
        get => GetMemorySize(); 
        set => SetMemorySize(value);
    }
    
    private void SetMemorySize(double value)
    {
        if (_memorySize == 0 && value > 0) _memorySize = value;
        else if (value <= 0) throw new ArgumentException("Memory size cannot be less or equal to zero.");
        else throw new InvalidOperationException("Memory size is already set.");
    }
    
    private double GetMemorySize()
    {
        return _memorySize;
    }
    
    public override int CompareTo(object obj)
    {
        switch (SortingParameters)
        {
            case StorageSortingParameters.Price: return ComparerByPrice(obj);
            case StorageSortingParameters.MemorySize: return ComparerByMemorySize(obj);
        }
        
        return base.CompareTo(obj);
    }
    
    private int ComparerByPrice(object obj)
    {
        if (obj is not Storage) throw new ArgumentException("Object is not a Storage.");
        
        Storage storeItem = (Storage)obj;
        if (storeItem.Price < Price) return 1;
        if (storeItem.Price == Price) return 0;
        return -1;
    }
    
    private int ComparerByMemorySize(object obj)
    {
        if (obj is not Storage) throw new ArgumentException("Object is not a Storage.");
        
        Storage storeItem = (Storage)obj;
        if (storeItem.MemorySize < MemorySize) return -1;
        if (storeItem.MemorySize == MemorySize) return 0;
        return 1;
    }
    
    public Storage(string name, int id, decimal price) : base(name, id, price)
    {
        SortingParameters = StorageSortingParameters.Price;
    }
}