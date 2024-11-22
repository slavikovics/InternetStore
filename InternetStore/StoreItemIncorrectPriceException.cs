namespace InternetStore;

public class StoreItemIncorrectPriceException : Exception
{
    public new string Message { get; private set; }
    
    public StoreItemIncorrectPriceException()
    {
        Message = "Price must be greater than zero";
    }
}