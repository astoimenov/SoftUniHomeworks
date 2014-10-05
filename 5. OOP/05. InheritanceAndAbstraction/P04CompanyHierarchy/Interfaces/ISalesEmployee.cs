namespace P04CompanyHierarchy
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        IEnumerable<Sale> Sales { get; set; } 
    }
}
