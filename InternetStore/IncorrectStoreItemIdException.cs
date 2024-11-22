namespace InternetStore;

public class IncorrectStoreItemIdException : Exception
{
    public override string Message { get;}
    
    public IncorrectStoreItemIdException()
    {
        Message = "Id must be unique in StoreSection";
    }
}