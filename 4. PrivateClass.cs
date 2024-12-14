class OuterClass
{
    // Private nested class
    private class InnerClass
    {
        public void Display()
        {
            Console.WriteLine("This is a method in a private nested class.");
        }
    }

    // Public method to create an instance of the private nested class and call its method
    public void AccessInnerClass()
    {
        InnerClass inner = new InnerClass();
        inner.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        OuterClass outer = new OuterClass();
        
        // Can't create an instance of InnerClass directly as it is private
        // OuterClass.InnerClass inner = new OuterClass.InnerClass(); // This will cause a compile-time error

        // Call the public method which accesses the private nested class
        outer.AccessInnerClass(); // This will work
    }
}
