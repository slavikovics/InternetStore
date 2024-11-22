using InternetStore;

namespace InternetStoreTest
{
    [TestClass]
    public sealed class ItemsFilterTest
    {
        [TestMethod]
        public void TestMethodTestPriceComparison()
        {
            StoreSection storeSection = new StoreSection("Main", "Test", "Test");
            StoreItem newItem1 = new StoreItem("1", "1", 100);
            StoreItem newItem2 = new StoreItem("1", "1", 13);
            StoreItem newItem3 = new StoreItem("1", "1", 26);

            try
            {

            }
            catch (StoreItemIncorrectPriceException exception)
            {
                Assert.AreEqual(exception.Message, "Price must be greater than zero");
            }
            StoreItem newItem4 = new StoreItem("1", "1", -10);
            
            storeSection.AddItem(newItem1);
            storeSection.AddItem(newItem2);
            storeSection.AddItem(newItem3);
            storeSection.AddItem(newItem4);
            
            List<StoreItem> filteredItems = ItemsFilter.FilterByPrice(storeSection.Items, 30);
            List<StoreItem> filteredItemsTest = new List<StoreItem>();
            filteredItemsTest.Add(newItem2);
            filteredItemsTest.Add(newItem3);

            Assert.AreEqual(ItemsFilter.CheckCollectionsAreTheSame(filteredItems, filteredItemsTest), true);
        }
    }
}
