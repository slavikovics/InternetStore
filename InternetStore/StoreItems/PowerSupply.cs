namespace InternetStore;

public class PowerSupply : StoreItem
{
    private PowerSupplyCertificate? _certificate;
    
    public PowerSupplyCertificate Certificate
    {
        get => GetCertificate(); 
        set => SetCertificate(value);
    }
    
    private void SetCertificate(PowerSupplyCertificate value)
    {
        if (_certificate is null ) _certificate = value; 
        else throw new InvalidOperationException("Power supply certificate is already set.");
    }
    
    private PowerSupplyCertificate GetCertificate()
    {
        if (_certificate is null) return PowerSupplyCertificate.None;
        return _certificate.Value;
    }
    
    private double _wattage;
    
    public double Wattage
    {
        get => GetWattage();
        set => SetWattage(value);
    }
    
    private void SetWattage(double value)
    {
        if (_wattage == 0 && value > 0) _wattage = value;
        else if (value <= 0) throw new ArgumentException("Wattage cannot be less or equal to zero.");
        else throw new InvalidOperationException("Wattage is already set.");
    }
    
    private double GetWattage()
    {
        return _wattage;
    }

    public double CalculateRealWattage()
    {
        switch (Certificate)
        {
            case PowerSupplyCertificate.EightyPlus: return Wattage * 0.8;
            case PowerSupplyCertificate.EightyPlusBronze: return Wattage * 0.85;
            case PowerSupplyCertificate.EightyPlusSilver: return Wattage * 0.89;
            case PowerSupplyCertificate.EightyPlusGold: return Wattage * 0.92;
            case PowerSupplyCertificate.EightyPlusPlatinum: return Wattage * 0.94;
            case PowerSupplyCertificate.EightyPlusTitanium: return Wattage * 0.96;
            default: return Wattage;
        }
    }
    
    public PowerSupply(string name, int id, decimal price) : base(name, id, price)
    {
        
    }
}