namespace Task1;

public interface IMyList<T>
{
    void Add(T item);
    T Get(int index);
    bool Contains(T obj);
}