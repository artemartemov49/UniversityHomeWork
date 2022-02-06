namespace Task2;

public interface IMyDictionary<TKey, TValue>
{
    TKey Add(TKey key, TValue value);
    TValue Get(TKey key);

}