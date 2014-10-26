namespace Estates.Data
{
    using System.Linq;
    using Engine;
    using Interfaces;

    class CustomEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPriceCommand(
                        decimal.Parse(cmdArgs[0]),
                        decimal.Parse(cmdArgs[1]));
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByPriceCommand(decimal minPrice, decimal maxPrice)
        {
            var rents = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Select(o => (IRentOffer)o)
                .Where(r => (r.PricePerMonth >= minPrice && r.PricePerMonth <= maxPrice))
                .OrderBy(r => r.PricePerMonth)
                .ThenBy(r => r.Estate.Name);
            return this.FormatQueryResults(rents);
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return this.FormatQueryResults(offers);
        }
    }
}
