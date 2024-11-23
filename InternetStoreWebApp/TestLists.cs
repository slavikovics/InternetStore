using InternetStore;

namespace InternetStoreWebApp
{
    public class TestLists
    {
        public List<PowerSupply> powerSupplies = new List<PowerSupply>();

        public TestLists()
        {
            powerSupplies.Add(new PowerSupply("1", "1", 100));
        }
    }
}
