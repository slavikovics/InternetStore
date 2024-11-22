namespace InternetStore;

public class IncorrectStoreItemNameException : Exception
{
    public override string Message { get;}
    
    public IncorrectStoreItemNameException()
    {
        Message = "Item Name must be unique in StoreSection";
    }
}