namespace FarmersCreed.Units.Abstract
{
    using System.Text;
    using Interfaces;

    public abstract class Animal : FarmUnit
    {
        protected Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
        }

        public abstract void Eat(IEdible food, int quantity);

        public virtual void Starve()
        {
            this.Health--;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            if (this.IsAlive)
            {
                output.Append(", Health: " + this.Health);
            }
            else
            {
                output.Append(", DEAD");
            }

            return output.ToString();
        }
    }
}
