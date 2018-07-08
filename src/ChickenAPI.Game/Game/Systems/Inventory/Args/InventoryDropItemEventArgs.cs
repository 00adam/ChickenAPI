using ChickenAPI.Core.ECS.Systems;
using ChickenAPI.Data.TransferObjects.Item;

namespace ChickenAPI.Game.Systems.Inventory.Args
{
    public class InventoryDropItemEventArgs : SystemEventArgs
    {
        public ItemInstanceDto ItemInstance { get; set; }
    }
}