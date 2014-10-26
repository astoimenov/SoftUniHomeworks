namespace FarmersCreed.Units
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Abstract;
    using Interfaces;

    public class Farm : GameObject, IFarm
    {
        private List<Plant> plants;
        private List<Animal> animals;
        private List<Product> products;

        public Farm(string id)
            : base(id)
        {
            this.plants = new List<Plant>();
            this.animals = new List<Animal>();
            this.products = new List<Product>();
        }

        public List<Plant> Plants
        {
            get { return this.plants; }
        }

        public List<Animal> Animals
        {
            get { return this.animals; }
        }

        public List<Product> Products
        {
            get { return this.products; }
        }

        public void AddProduct(Product product)
        {
            if (this.products.Count > 0)
            {
                foreach (Product product1 in this.products)
                {
                    if (product.Id == product1.Id)
                    {
                        product1.Quantity += product.Quantity;
                    }
                    else
                    {
                        this.products.Add(product);
                        break;
                    }
                }
            }
            else
            {
                this.products.Add(product);
            }
        }

        public void Exploit(IProductProduceable productProducer)
        {
            productProducer.GetProduct();
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            animal.Eat(edibleProduct, productQuantity);
        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            foreach (Plant plant in this.plants)
            {
                if (plant.IsAlive)
                {
                    if (plant.HasGrown)
                    {
                        plant.Wither();
                    }
                    else
                    {
                        plant.Grow();
                    }
                }
            }

            foreach (Animal animal in this.animals)
            {
                if (animal.IsAlive)
                {
                    animal.Starve();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            var ani = this.animals.Where(x => x.IsAlive)
                .OrderBy(x => x.Id);
            foreach (Animal animal in ani)
            {
                output.AppendLine(animal.ToString());
            }

            var pla = this.plants.Where(x => x.IsAlive)
                .OrderBy(x => x.Health)
                .ThenBy(x => x.Id);
            foreach (Plant plant in pla)
            {
                output.AppendLine(plant.ToString());
            }

            var pro = this.products.OrderBy(x => x.ProductType.ToString())
                .ThenByDescending(x => x.Quantity)
                .ThenBy(x => x.Id);
            foreach (Product product in pro)
            {
                output.AppendLine(product.ToString());
            }

            return output.ToString();
        }
    }
}
