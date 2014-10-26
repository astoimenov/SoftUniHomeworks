namespace FarmersCreed.Units.Plants
{
    using System;
    using Abstract;

    public class CherryTree : FoodPlant
    {
        private const int HealthEffect = 2;

        public CherryTree(string id) 
            : base(id, 14, 4, 3)
        {
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new ArgumentException(this.Id + " cannot produce, because it's dead!");
            }

            return new Food(
                this.Id + "Product", 
                ProductType.Cherry, 
                FoodType.Organic, 
                this.ProductionQuantity,
                HealthEffect);
        }
    }
}
