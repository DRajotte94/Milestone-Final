using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Final
{
    class InventoryManager
    {
        public static List<Bike> createInventory()
        {
            // inventory list of bikes (several bikes pre loaded into list for testing)
            List<Bike> inventory = new List<Bike>();

            // populate list with randomly generated objects for testing
            for (int i = 0; i < 50; i++)
            {
                Bike bike = new Bike(); // create random bike
                inventory.Add(bike);
            }

            return inventory;
        }
    }
}
