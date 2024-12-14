using System;

public struct MyStruct
{
    public int myField; // Default access modifier is private for struct members

    public void Display()
    {
        Console.WriteLine("MyStruct Display: " + myField);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyStruct myStructInstance = new MyStruct();
        myStructInstance.myField = 10;
        myStructInstance.Display(); // This will display: MyStruct Display: 10
    }
}
