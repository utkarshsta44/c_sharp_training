using System;

interface IMyInterface<T>
{
    void MyMethod(T value);
}

class MyClass<T> : IMyInterface<T>
{
    public void MyMethod(T value)
    {
        Console.WriteLine("Received value: " + value);
    }
}

class Program
{
    static void Main()
    {
        IMyInterface<int> intInstance = new MyClass<int>();
        intInstance.MyMethod(10);

        IMyInterface<string> stringInstance = new MyClass<string>();
        stringInstance.MyMethod("Hello, Generics!");
    }
}
