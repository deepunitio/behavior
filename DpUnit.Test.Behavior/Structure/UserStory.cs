#nullable enable
using System.Runtime.CompilerServices;

namespace DpUnit.Test.Behavior.Structure
{
    public partial class UserStory<T> where T : class
    {
        private T Fixture { get; }

        /// <summary>
        /// An explicit title.
        /// </summary>
        protected UserStory<T> Title(string text) => this;

        /// <summary>
        /// A short introductory section with the following structure:
        /// </summary>
        public UserStory<T> Narrative => this;
        
        /// <summary>
        /// As a: the person or role who will benefit from the feature;
        /// </summary>
        public UserStory<T> As(string text) => this;
        
        /// <summary>
        ///  I want: the feature;
        /// </summary>
        public UserStory<T> I(string text) => this;

        /// <summary>
        /// so that: the benefit or value of the feature.
        /// </summary>
        public UserStory<T> So(string text) => this;
        


        protected UserStory(T fixture)
        {
            Fixture = fixture;
        }
    }
    
    /// <summary>
    /// Acceptance criteria
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class UserStory<T> where T : class
    {
        
        
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
    }    
}