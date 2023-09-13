namespace ide0028test
{
    internal class Broken
    {
        public Broken()
        {
            Property = new List<int>();
        }

        public List<int>? Property { get; }

        public void Method()
        {
            List<int> field = new List<int>();
        }
    }

    internal class Working
    {
        public Working()
        {
        }

        public List<int>? Property { get; } = new(); //no capacity required

        public void Method()
        {
            List<int> field = new(100); //capacity required here
        }
    }
}
