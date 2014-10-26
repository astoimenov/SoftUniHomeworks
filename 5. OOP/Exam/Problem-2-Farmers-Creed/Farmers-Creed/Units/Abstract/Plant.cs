namespace FarmersCreed.Units.Abstract
{
    using System;
    using System.Text;

    public abstract class Plant : FarmUnit
    {
        private int growTime;

        protected Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.growTime = growTime;
        }

        public bool HasGrown
        {
            get
            {
                if (this.growTime == 0)
                {
                    return true;
                }

                return false;
            }
        }

        public int GrowTime
        {
            get
            {
                return this.growTime;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("growTime", "Grow time cannot be negative!");
                }

                this.growTime = value;
            }
        }

        public virtual void Water()
        {
            this.Health += 2;
        }

        public virtual void Wither()
        {
            this.Health--;
        }

        public virtual void Grow()
        {
            this.growTime--;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            if (this.IsAlive)
            {
                output.Append(", Health: " + this.Health);
                output.Append(", Grown: " + (this.HasGrown ? "Yes" : "No"));
            }
            else
            {
                output.Append(", DEAD");
            }

            return output.ToString();
        }
    }
}
