using InternetStore;

namespace InternetStoreTest;

[TestClass]
public class StoreItemTest
{
    [TestMethod]
    public void TestMethodTestManufacturer()
    {
        StoreItem item = new StoreItem("1", 1, 100);

        try
        {
            item.Manufacturer = "";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Manufacturer cannot be empty.");
        }
        Assert.AreEqual(item.Manufacturer, "");

        Assert.AreEqual(item.ToString().Contains("Manufacturer"), false);
        
        item.Manufacturer = "Manufacturer";
        Assert.AreEqual(item.Manufacturer, "Manufacturer");
        
        try
        {
            item.Manufacturer = "New Manufacturer";
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "Manufacturer is already set.");
        }
        
        Assert.AreEqual(item.ToString().Contains("Manufacturer"), true);
    }
}