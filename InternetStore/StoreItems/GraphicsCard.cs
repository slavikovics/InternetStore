namespace InternetStore;

public class GraphicsCard : StoreItem
{
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
    
    public GraphicsCard(string name, string id, decimal price) : base(name, id, price)
    {
        
    }
}