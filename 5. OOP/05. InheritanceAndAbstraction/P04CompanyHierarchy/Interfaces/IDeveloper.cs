namespace P04CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        IEnumerable<Project> Projects { get; set; } 
    }
}
