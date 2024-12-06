using InternetStore;

namespace InternetStoreTest;

[TestClass]
public sealed class IncorrectStoreItemExceptionsTest
{
    [TestMethod]
    public void TestIncorrectStoreItemIdException()
    {
        StoreSection storeSection = new StoreSection("Main", "Test", "Test");
        
        try
        {
            StoreItem newItem4 = new StoreItem("1", 1, 10);
            storeSection.AddItem(newItem4);
            StoreItem newItem5 = new StoreItem("2", 1, 10);
            storeSection.AddItem(newItem5);
        }
        catch (Exception exception)
        {
            Assert.AreEqual(exception.Message, "Item Id must be unique in StoreSection");
        }
    }
    
    [TestMethod]
    public void TestIncorrectStoreItemNameException()
    {
        StoreSection storeSection = new StoreSection("Main", "Test", "Test");
        
        try
        {
            StoreItem newItem4 = new StoreItem("1", 1, 10);
            storeSection.AddItem(newItem4);
            StoreItem newItem5 = new StoreItem("1", 2, 10);
            storeSection.AddItem(newItem5);
        }
        catch (Exception exception)
        {
            Assert.AreEqual(exception.Message, "Item Name must be unique in StoreSection");
        }
    }
    
    [TestMethod]
    public void TestIncorrectStoreItemPriceException()
    {
        StoreSection storeSection = new StoreSection("Main", "Test", "Test");
        
        try
        {
            StoreItem newItem4 = new StoreItem("1", 1, -10);
            storeSection.AddItem(newItem4);
        }
        catch (Exception exception)
        {
            Assert.AreEqual(exception.Message, "Item Price must be greater than zero");
        }
    }
}