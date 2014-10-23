namespace LockHeedCore.Inventory.Slots
{
    using System.Collections.Generic;
    using Interfaces;

    public class Slot : ISlot, IEquippedItems
    {
        private List<IEquippedItems> equippedItemsList = new List<IEquippedItems>();

        public List<IEquippedItems> EquippedItemsList
        {
            get { return this.equippedItemsList; }
        }

        public void Equip(IEquippedItems item)
        {
            if (this.IsItemEquipped(item))
            {
                this.equippedItemsList.Remove(item);
            }

            this.equippedItemsList.Add(item);
        }

        public void UnEquip(IEquippedItems item)
        {
            this.equippedItemsList.Remove(item);
        }

        private bool IsItemEquipped(IEquippedItems item)
        {
            if (this.equippedItemsList.IndexOf(item) != -1)
            {
                return true;
            }

            return false;
        }
    }
}
