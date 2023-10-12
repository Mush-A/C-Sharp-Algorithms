using System.Collections.Generic;

namespace Interview.Sorting;

public class Sort<T> : ISort<T> where T : IComparable<T>
{
    private readonly List<T> _list;
    public List<T>? sortedList { get; private set; }

    public Sort(List<T> list)
    {
        _list = list;
    }

    public ISort<T> BubbleSort()
    {
        sortedList = new List<T>(_list);
        List<T> list = sortedList;

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j].CompareTo(list[j + 1]) > 0)
                {
                    T temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        return this;   
    }

    public string Print() 
        => sortedList != null && sortedList.Count > 0 ?
        string.Join(", ", sortedList) : 
        throw new Exception("Nothing to print");

}
