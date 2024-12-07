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
            StoreItem newItem1 = new StoreItem("1", 100);
            StoreItem newItem2 = new StoreItem("2", 13);
            StoreItem newItem3 = new StoreItem("3", 26);
            
            storeSection.AddItem(newItem1);
            storeSection.AddItem(newItem2);
            storeSection.AddItem(newItem3);
            
            List<StoreItem> filteredItems = ItemsFilter.FilterByPrice(storeSection.Items, 30);
            List<StoreItem> filteredItemsTest =
            [
                newItem2,
                newItem3
            ];

            Assert.AreEqual(ItemsFilter.CheckCollectionsHaveTheSameElements(filteredItems, filteredItemsTest), true);
            
            ItemsFilter.SortByPrice(filteredItemsTest);
            List<StoreItem> sortedItemsTest =
            [
                newItem2,
                newItem3,
                newItem1
            ];
            
            Assert.AreEqual(ItemsFilter.CheckCollectionsHaveTheSameElements(storeSection.Items, sortedItemsTest), true);
        }
    }
}
