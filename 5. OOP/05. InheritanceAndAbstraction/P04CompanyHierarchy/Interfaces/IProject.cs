namespace P04CompanyHierarchy
{
    using System;

    public interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        ProjectState State { get; set; }

        void CloseProject();
    }
}
