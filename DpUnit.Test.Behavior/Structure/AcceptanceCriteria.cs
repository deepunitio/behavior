namespace DpUnit.Test.Behavior.Structure
{
    /// <summary>
    /// A description of each specific scenario of the narrative with the following structure:
    /// GIVEN -> WHEN -> THEN
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AcceptanceCriteria<T> where T : class
    {
        private T Fixture { get; }        
        
        /// <summary>
        /// Given [initial context]
        /// </summary>
        protected T Given => Fixture;
        
        /// <summary>
        ///  when [event occurs]
        /// </summary>
        protected T When => Fixture;
        
        /// <summary>
        /// then [ensure some outcomes]
        /// </summary>
        protected T Then => Fixture;
        

        public AcceptanceCriteria(T fixture)
        {
            Fixture = fixture;
        }
    }
}