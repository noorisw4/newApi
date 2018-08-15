using System;
using System.Collections.Generic;
using MyNewAPI.Model;

namespace MyNewAPI.Services
{
    public interface IInventoryServices
    {
        Inventory AddInventoryItems(Inventory items);
        Dictionary<string, Inventory> GetInventory();

    }
}