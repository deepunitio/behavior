using System;
using System.Diagnostics;

namespace DpUnit.Test.Behavior.Samples.SystemUnderTest
{
    public class Person
    {
        private string Name { get; }
        private string LastName { get; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string GetFullName(Treatment treatment) => treatment switch
        {
            Treatment.Formal => GetFormalName(),
            Treatment.Informal => GetInformalTreatment(),
            Treatment.Default => GetDefaultFullName(),
            _ => throw new ArgumentOutOfRangeException(nameof(treatment), treatment, null)
        };
        
        
        public string GetDefaultFullName() => $"{Name} {LastName}";
        public string GetFormalName() => $"Mx, {LastName}";
        public string GetInformalTreatment() => $"Hi, {Name}!";
    }
}