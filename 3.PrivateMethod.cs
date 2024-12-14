using System;

class ExampleClass
{
    // Private method
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    // Public method that calls the private method
    public void CallPrivateMethod()
    {
        PrivateMethod();
    }
}

class main
{
    static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass();
        
        // Can't call PrivateMethod() directly as it is private
        // example.PrivateMethod(); // This will cause a compile-time error

        // Call the public method which in turn calls the private method
        example.CallPrivateMethod(); // This will work
    }
}
