using System;
using System.Collections.Generic;
using MyNewAPI.Model;

namespace MyNewAPI.Services
{
    public class InventoryServices:IInventoryServices
    {
        private readonly Dictionary<string, Inventory> _Inventory;

        public InventoryServices(){
            _Inventory = new Dictionary<string, Inventory>();
        }
        public Inventory AddInventoryItems(Inventory items){
            _Inventory.Add(items.ItemName, items);

            return items;


        }
        public Dictionary<string,Inventory> GetInventory(){
            return _Inventory;
        }
    }
}
