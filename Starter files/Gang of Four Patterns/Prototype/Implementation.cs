namespace Prototype
{
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone();
    }

    /// <summary>
    /// ConcretePrototype
    /// </summary>
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    /// <summary>
    /// ConcretePrototype
    /// </summary>
    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
