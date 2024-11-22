namespace InternetStore;

public class IncorrectStoreItemIdException : Exception
{
    public override string Message { get;}
    
    public IncorrectStoreItemIdException()
    {
        Message = "Item Id must be unique in StoreSection";
    }
}