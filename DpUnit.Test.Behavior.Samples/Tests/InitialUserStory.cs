using DpUnit.Test.Behavior.Structure;
using Xunit;

namespace DpUnit.Test.Behavior.Samples.Tests
{
    public class InitialUserStory: UserStory<InitialFixture>, IClassFixture<InitialFixture>
    {
        public InitialUserStory(InitialFixture fixture) : base(fixture)
        {
            Title("An explicit title");

            Narrative
                .As("a the person or role who will benefit from the feature")
                .I("want the feature")
                .So("that: the benefit or value of the feature");
        }


        [Fact]
        public void Formal_Treatment_Scenario()
        {
            Given
                .A_person_with_name("Alice", "Walker")
                .In_a_formal_context();
            When
                .I_get_the_full_name();
            Then
                .Full_name_should_be_a_formal_treatment();
        }
    }
}