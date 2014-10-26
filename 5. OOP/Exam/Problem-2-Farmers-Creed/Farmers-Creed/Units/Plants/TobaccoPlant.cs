namespace FarmersCreed.Units.Plants
{
    using System;
    using Abstract;

    public class TobaccoPlant : Plant
    {
        public TobaccoPlant(string id) 
            : base(id, 12, 10, 4)
        {
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new ArgumentException(this.Id + " cannot produce, because it's dead!");
            }

            return new Product(this.Id + "Product", ProductType.Tobacco, this.ProductionQuantity);
        }

        public override void Grow()
        {
            this.GrowTime -= 2;
        }
    }
}
