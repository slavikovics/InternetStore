using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.StoreFilters
{
    public static class PowerSuppliesFilter
    {
        public static PowerSupply FindPowerSupplyById(List<PowerSupply> powerSupplies, string id)
        {
            foreach (PowerSupply powerSupply in powerSupplies)
            {
                if (powerSupply.Id == id) return powerSupply;
            }

            return null;
        }
    }
}
