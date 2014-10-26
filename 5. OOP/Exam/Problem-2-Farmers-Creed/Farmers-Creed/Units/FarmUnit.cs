namespace FarmersCreed.Units
{
    using System;
    using Abstract;
    using Interfaces;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        private int health;
        private int productionQuantity;

        protected FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            this.health = health;
            this.productionQuantity = productionQuantity;
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative!", "health");
                }

                this.health = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                if (this.Health == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public int ProductionQuantity
        {
            get
            {
                return this.productionQuantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "ProductionQuantity", "Product quantity cannot be negative!");
                }

                this.productionQuantity = value;
            }
        }

        public abstract Product GetProduct();
    }
}
