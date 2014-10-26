namespace FarmersCreed.Units.Animals
{
    using Abstract;
    using Interfaces;

    public class Swine : Animal
    {
        private const int HealthEffect = 5;

        public Swine(string id)
            : base(id, 20, 1)
        {
        }

        public override Product GetProduct()
        {
            this.Health = 0;
            return new Food(
                this.Id + "Product",
                ProductType.PorkMeat,
                FoodType.Meat,
                this.ProductionQuantity,
                HealthEffect);
        }

        public override void Eat(IEdible food, int quantity)
        {
            this.Health += 2 * quantity * food.HealthEffect;
            food.Quantity -= quantity;
        }

        public override void Starve()
        {
            this.Health -= 3;
        }
    }
}
