namespace P04CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IManager
    {
        IEnumerable<Employee> Employees { get; set; }
    }
}
