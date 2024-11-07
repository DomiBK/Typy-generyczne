
public class GenericSorter<T> where T : IComparable<T>
{
    public List<T> Sort(List<T> inputList)
    {
        List<T> sortedList = new List<T>();
        
        foreach (T item in inputList)
        {
            InsertInOrder(sortedList, item);
        }
        
        return sortedList;
    }

    private void InsertInOrder(List<T> list, T item)
    {
        int index = FindInsertPosition(list, item);
        list.Insert(index, item);
    }

    private int FindInsertPosition(List<T> list, T item)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(item) >= 0)
                return i;
        }
        return list.Count;
    }
}

public class GenericComparer<T1, T2>
{
    public bool Compare(T1 obj1, T2 obj2)
    {
        if (!(obj1 is IComparable<T1>) || !(obj2 is IComparable<T2>))
        {
            throw new ArgumentException("Obiekty muszą implementować interfejs IComparable");
        }

        dynamic dynObj1 = Convert.ChangeType(obj1, typeof(T1));
        dynamic dynObj2 = Convert.ChangeType(obj2, typeof(T2));

        return dynObj1.CompareTo(dynObj2) < 0;
    }
}

class Program
{
    static void Main()
    {
        // Testowanie sortowania generycznego
        Console.WriteLine("Sortowanie generyczne:");
        
        List<int> intList = new List<int> { 64, 34, 25, 12, 22, 11, 90 };
        var intSorter = new GenericSorter<int>();
        var sortedInts = intSorter.Sort(intList);
        PrintList("Posortowana lista liczb całkowitych:", sortedInts);

        List<double> doubleList = new List<double> { 3.14, 2.71, 1.61, 0.577 };
        var doubleSorter = new GenericSorter<double>();
        var sortedDoubles = doubleSorter.Sort(doubleList);
        PrintList("\nPosortowana lista liczb zmiennoprzecinkowych:", sortedDoubles);

        // Testowanie porównywania generycznego
        Console.WriteLine("\nPorównywanie generyczne:");
        
        var comparer = new GenericComparer<int, double>();

        Console.WriteLine($"Czy 10 jest mniejsze od 5.5? {comparer.Compare(10, 5.5)}");
        Console.WriteLine($"Czy 5 jest mniejsze od 10.0? {comparer.Compare(5, 10.0)}");
        Console.WriteLine($"Czy 7 jest mniejsze od 7.0? {comparer.Compare(7, 7.0)}");

        try
        {
            Console.WriteLine($"Porównanie 'hello' z 42: {comparer.Compare("hello", 42)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd przy porównywaniu 'hello' z 42: {ex.Message}");
        }

        try
        {
            Console.WriteLine($"Porównanie 42 z 'world': {comparer.Compare(42, "world")}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd przy porównywaniu 42 z 'world': {ex.Message}");
        }
    }

    static void PrintList<T>(string message, List<T> list)
    {
        Console.WriteLine($"{message} [{string.Join(", ", list)}]");
    }
}
