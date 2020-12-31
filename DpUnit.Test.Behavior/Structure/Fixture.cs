namespace DpUnit.Test.Behavior.Structure
{
    public class Fixture<T> where T : class
    {
        public T And => this as T;
        public T It(object it) => this as T;
    }
}