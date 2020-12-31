using DpUnit.Test.Behavior.Samples.SystemUnderTest;
using DpUnit.Test.Behavior.Structure;
using FluentAssertions;

namespace DpUnit.Test.Behavior.Samples.Tests
{
    public class InitialFixture : Fixture<InitialFixture>
    {
        public Person Person { get; set; }
        public Treatment Treatment { get; set; }
        public string FullName { get; set; }
    }

    public static class InitialFixtureContexts
    {
        public static InitialFixture A_person_with_name(this InitialFixture fixture, string name, string lastName)
        {
            fixture.Person = new Person(name, lastName);
            return fixture;
        }

        public static InitialFixture In_a_formal_context(this InitialFixture fixture)
        {
            fixture.Treatment = Treatment.Formal;
            return fixture;
        }
    }

    public static class InitialFixtureEvents
    {
        public static InitialFixture I_get_the_full_name(this InitialFixture fixture)
        {
            fixture.FullName = fixture.Person.GetFullName(fixture.Treatment);
            return fixture;
        }
    }

    public static class InitialFixtureAssertions
    {
        public static InitialFixture Full_name_should_be_a_formal_treatment(this InitialFixture fixture)
        {
            fixture.FullName.Should().Be(fixture.Person.GetFormalName());
            return fixture;
        }     
        
        public static InitialFixture Full_name_should_be_a_informal_treatment(this InitialFixture fixture)
        {
            fixture.FullName.Should().Be(fixture.Person.GetInformalTreatment());
            return fixture;
        }
        
        public static InitialFixture Full_name_should_be_a_default_treatment(this InitialFixture fixture)
        {
            fixture.FullName.Should().Be(fixture.Person.GetDefaultFullName());
            return fixture;
        }            
    }
}