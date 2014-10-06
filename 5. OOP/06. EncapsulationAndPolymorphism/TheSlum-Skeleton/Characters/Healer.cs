namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team, int healthPoints = 75, int defensePoints = 50, int range = 6, int healingPoints = 60)
            : base(id, x, y, team, healthPoints, defensePoints, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = from target in targetsList
                          where target.IsAlive && target.Team == this.Team && target != this
                          orderby target.HealthPoints
                          select target;

            return targets.FirstOrDefault();
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
            output += ", Healing: " + this.HealingPoints;
            return output;
        }
    }
}
