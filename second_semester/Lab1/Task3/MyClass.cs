namespace Task3;

public class MyClass
{
    public static T? FactoryMethod<T>(params object[] arguments) where T : class, new()
    {
        return Activator.CreateInstance(typeof(T), arguments) as T;
    }
}