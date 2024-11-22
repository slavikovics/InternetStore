namespace InternetStore;

public class IncorrectStoreItemNameException : Exception
{
    public override string Message { get;}
    
    public IncorrectStoreItemNameException()
    {
        Message = "Name must be unique in StoreSection";
    }
}