namespace FarmersCreed.Units.Abstract
{
    using System;

    public abstract class FoodPlant : Plant, IProduct
    {
        private ProductType productType;
        private int quantity;

        protected FoodPlant(string id, int health, int productionQuantity, int growTime) 
            : base(id, health, productionQuantity, growTime)
        {
        }

        public ProductType ProductType
        {
            get { return this.productType; }

            set { this.productType = value; }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("quantity", "Quantity cannot be negative!");
                }

                this.quantity = value;
            }
        }

        public override void Water()
        {
            this.Health++;
        }

        public override void Wither()
        {
            this.Health -= 2;
        }
    }
}
