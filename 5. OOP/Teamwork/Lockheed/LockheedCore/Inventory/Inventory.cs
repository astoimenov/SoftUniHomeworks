namespace LockHeedCore.Inventory
{
    using System.Collections.Generic;
    using Interface;

    public class Inventory : ITakeable, IRemovable
    {
        protected readonly int InventoryLimit;
        private List<Item> itemList;

        protected Inventory(int inventoryLimit = 40)
        {
            this.ItemList = new List<Item>(inventoryLimit);
            this.InventoryLimit = inventoryLimit;
        }

        public List<Item> ItemList
        {
            get
            {
                return this.itemList;
            }

            private set
            {
                this.itemList = value;
            }
        }

        public int InventoryItemsCount
        {
            get
            {
                return this.itemList.Count;
            }
        }

        public void TakeItem(Item item)
        {
            if (this.InventoryItemsCount < this.InventoryLimit)
            {
                this.ItemList.Add(item);
            }
        }

        public void DropItem(Item item)
        {
            if (this.InventoryItemsCount > 0)
            {
                this.ItemList.Remove(item);
            }
        }
    }
}
