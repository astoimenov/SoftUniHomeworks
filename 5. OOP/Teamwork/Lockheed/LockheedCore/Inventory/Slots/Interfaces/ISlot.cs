namespace LockHeedCore.Inventory.Slots.Interfaces
{
    using System.Collections.Generic;

    public interface ISlot
    {
        List<IEquippedItems> EquippedItemsList { get; }

        void Equip(IEquippedItems item);

        void UnEquip(IEquippedItems item);
    }
}