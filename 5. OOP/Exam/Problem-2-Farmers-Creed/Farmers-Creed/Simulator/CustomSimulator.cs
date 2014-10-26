using System;

namespace FarmersCreed.Simulator
{
    using System.Linq;
    using Interfaces;
    using Units;
    using Units.Animals;
    using Units.Plants;

    public class CustomSimulator : FarmSimulator
    {
        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string type = inputCommands[1];
            string id = inputCommands[2];

            switch (type)
            {
                case "CherryTree":
                    {
                        var cherryTree = new CherryTree(id);
                        this.farm.Plants.Add(cherryTree);
                    }

                    break;
                case "Swine":
                    {
                        var swine = new Swine(id);
                        this.farm.Animals.Add(swine);
                    }

                    break;
                case "Cow":
                    {
                        var cow = new Cow(id);
                        this.farm.Animals.Add(cow);
                    }

                    break;
                case "TobaccoPlant":
                    {
                        var tobacco = new TobaccoPlant(id);
                        this.farm.Plants.Add(tobacco);
                    }

                    break;
                default:
                    base.AddObjectToFarm(inputCommands);
                    break;
            }
        }

        protected override void ProcessInput(string input)
        {
            string[] inputCommands = input.Split(' ');

            string action = inputCommands[0];

            switch (action)
            {
                case "feed":
                    {
                        string animalId = inputCommands[1];
                        string foodId = inputCommands[2];
                        int quantity = int.Parse(inputCommands[3]);
                        var animal = this.farm.Animals.First(x => x.Id == animalId);
                        var food = this.farm.Products.Where(x => x.Id == foodId)
                            .Select(x => (IEdible)x);
                        animal.Eat(food.First(), quantity);
                    }

                    break;
                case "water":
                    {
                        string plantId = inputCommands[1];
                        var plant = this.farm.Plants.Find(x => x.Id == plantId);
                        plant.Water();
                    }

                    break;
                case "exploit":
                    {
                        string type = inputCommands[1];
                        string id = inputCommands[2];
                        if (type == "animal")
                        {
                            var animal = this.farm.Animals.Find(x => x.Id == id);
                            Product product = animal.GetProduct();
                            this.farm.Products.Add(product);
                        }
                        else if (type == "plant")
                        {
                            var plant = this.farm.Plants.Find(x => x.Id == id);
                            Product product = plant.GetProduct();
                            this.farm.AddProduct(product);
                        }
                        else
                        {
                            throw new ArgumentException("Invalid exploit command!");
                        }
                    }

                    break;
                default:
                    base.ProcessInput(input);
                    break;
            }
        }
    }
}
