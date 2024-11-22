namespace InternetStore;

public class IncorrectStoreItemPriceException : Exception
{
    public override string Message { get; }
    
    public IncorrectStoreItemPriceException()
    {
        Message = "Price must be greater than zero";
    }
}