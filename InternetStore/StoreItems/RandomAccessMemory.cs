﻿namespace InternetStore;

public class RandomAccessMemory : StoreItem
{
    public RandomAccessMemorySortingParameters SortingParameters { get; set; }
    
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
            case RandomAccessMemorySortingParameters.Price: return ComparerByPrice(obj);
            case RandomAccessMemorySortingParameters.MemorySize: return ComparerByMemorySize(obj);
        }
        
        return base.CompareTo(obj);
    }
    
    private int ComparerByPrice(object obj)
    {
        if (obj is not RandomAccessMemory) throw new ArgumentException("Object is not a RandomAccessMemory.");
        
        RandomAccessMemory storeItem = (RandomAccessMemory)obj;
        if (storeItem.Price < Price) return 1;
        if (storeItem.Price == Price) return 0;
        return -1;
    }
    
    private int ComparerByMemorySize(object obj)
    {
        if (obj is not RandomAccessMemory) throw new ArgumentException("Object is not a RandomAccessMemory.");
        
        RandomAccessMemory storeItem = (RandomAccessMemory)obj;
        if (storeItem.MemorySize < MemorySize) return -1;
        if (storeItem.MemorySize == MemorySize) return 0;
        return 1;
    }
    
    public RandomAccessMemory(string name, decimal price) : base(name, price)
    {
        SortingParameters = RandomAccessMemorySortingParameters.Price;
    }
}