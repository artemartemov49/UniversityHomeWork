namespace Task1;

public static class ListUtil
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        var result = new T[list.Size];
        for (var i = 0; i < list.Size; i++)
        {
            result[i] = list.Get(i);
        }

        return result;
    }
}