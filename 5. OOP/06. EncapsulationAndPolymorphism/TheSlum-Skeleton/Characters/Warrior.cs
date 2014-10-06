namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Warrior : Character, IAttack
    {
        public Warrior(string id, int x, int y, Team team, int attackPoints = 150, int healthPoints = 200, int defensePoints = 100, int range = 2) 
            : base(id, x, y, team, healthPoints, defensePoints, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(c => (c.IsAlive && this.Team != c.Team));
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);
            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += ", Attack: " + this.AttackPoints;
            return output;
        }
    }
}
