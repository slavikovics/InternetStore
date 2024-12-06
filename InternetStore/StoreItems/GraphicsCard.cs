namespace InternetStore;

public class GraphicsCard : StoreItem
{
    public GraphicsCardSortingParameters SortingParameters { get; set; }
    
    private string? _videoMemoryType;

    public string VideoMemoryType
    {
        get => GetVideoMemoryType();
        set => SetVideoMemoryType(value);
    }
    
    private void SetVideoMemoryType(string value)
    {
        if (_videoMemoryType is null && value != "") _videoMemoryType = value;
        else if (value == "") throw new ArgumentException("Video memory type cannot be empty.");
        else throw new InvalidOperationException("Video memory type is already set.");
    }
    
    private string GetVideoMemoryType()
    {
        if (_videoMemoryType is null) return "";
        return _videoMemoryType;
    }
    
    private string? _graphicsProcessorName;

    public string GraphicsProcessorName
    {
        get => GetGraphicsProcessorName(); 
        set => SetGraphicsProcessorName(value);
    }
    
    private void SetGraphicsProcessorName(string value)
    {
        if (_graphicsProcessorName is null && value != "") _graphicsProcessorName = value;
        else if (value == "") throw new ArgumentException("Graphics processor name cannot be empty.");
        else throw new InvalidOperationException("Graphics processor name is already set.");
    }
    
    private string GetGraphicsProcessorName()
    {
        if (_graphicsProcessorName is null) return "";
        return _graphicsProcessorName;
    }
    
    private double _videoMemorySize;
    
    public double VideoMemorySize
    {
        get => GetVideoMemorySize(); 
        set => SetVideoMemorySize(value);
    }
    
    private void SetVideoMemorySize(double value)
    {
        if (_videoMemorySize == 0 && value > 0) _videoMemorySize = value;
        else if (value <= 0) throw new ArgumentException("Video memory size cannot be less or equal to zero.");
        else throw new InvalidOperationException("Video memory size is already set.");
    }
    
    private double GetVideoMemorySize()
    {
        return _videoMemorySize;
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
    
    public override int CompareTo(object obj)
    {
        switch (SortingParameters)
        {
            case GraphicsCardSortingParameters.Price: return ComparerByPrice(obj);
            case GraphicsCardSortingParameters.VideoMemorySize: return ComparerByVideoMemorySize(obj);
        }
        
        return base.CompareTo(obj);
    }

    private int ComparerByPrice(object obj)
    {
        if (obj is not GraphicsCard) throw new ArgumentException("Object is not a GraphicsCard.");
        
        GraphicsCard storeItem = (GraphicsCard)obj;
        if (storeItem.Price < Price) return 1;
        if (storeItem.Price == Price) return 0;
        return -1;
    }
    
    private int ComparerByVideoMemorySize(object obj)
    {
        if (obj is not GraphicsCard) throw new ArgumentException("Object is not a GraphicsCard.");
        
        GraphicsCard storeItem = (GraphicsCard)obj;
        if (storeItem.VideoMemorySize < VideoMemorySize) return -1;
        if (Math.Abs(storeItem.VideoMemorySize - VideoMemorySize) < 0.001) return 0;
        return 1;
    }
    
    public GraphicsCard(string name, int id, decimal price) : base(name, id, price)
    {
        SortingParameters = GraphicsCardSortingParameters.Price;
    }
}