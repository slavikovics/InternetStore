namespace InternetStore;

public class Motherboard : StoreItem
{
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
    
    private string? _chipset;

    public string Chipset
    {
        get => GetChipset(); 
        set => SetChipset(value);
    }
    
    private void SetChipset(string value)
    {
        if (_chipset is null && value != "") _chipset = value;
        else if (value == "") throw new ArgumentException("Chipset cannot be empty.");
        else throw new InvalidOperationException("Chipset is already set.");
    }
    
    private string GetChipset()
    {
        if (_chipset is null) return "";
        return _chipset;
    }

    public Motherboard(string name, string id, decimal price) : base(name, id, price)
    {
        
    }
}