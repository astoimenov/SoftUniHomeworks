namespace P04CompanyHierarchy
{
    public interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}
