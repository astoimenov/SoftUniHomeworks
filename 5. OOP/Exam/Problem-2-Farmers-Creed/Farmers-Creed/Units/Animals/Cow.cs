namespace FarmersCreed.Units.Animals
{
    using System;
    using Abstract;
    using Interfaces;

    public class Cow : Animal
    {
        private const int HealthEffect = 4;

        public Cow(string id)
            : base(id, 15, 6)
        {
        }

        public override Product GetProduct()
        {
            if (this.Health >= 2)
            {
                this.Health -= 2;
            }
            else
            {
                this.Health = 0;
            }

            return new Food(
                this.Id + "Product",
                ProductType.Milk,
                FoodType.Organic,
                this.ProductionQuantity,
                HealthEffect);
        }

        public override void Eat(IEdible food, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("quantity", "Quantity cannot be negative!");
            }

            if (food.FoodType == FoodType.Organic)
            {
                this.Health += food.HealthEffect * quantity;
                food.Quantity -= quantity;
            }
            else if (food.FoodType == FoodType.Meat)
            {
                if (this.Health >= food.HealthEffect * quantity)
                {
                    this.Health -= food.HealthEffect * quantity;
                }
                else
                {
                    this.Health = 0;
                }

                food.Quantity -= quantity;
            }
            else
            {
                throw new ArgumentException("The cow don't eat this food!", "food");
            }
        }
    }
}
