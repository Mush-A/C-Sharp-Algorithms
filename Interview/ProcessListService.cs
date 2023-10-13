using Interview.Sorting;

namespace Interview;

public class ProcessListService<T> where T : IComparable<T>
{
    private readonly ISort<T> _sort; 
    public ProcessListService(ISort<T> Sort)
    {
        _sort = new Sort<T>();
    }

    public List<T> SortList(List<T> list)
    {
        var sortedList = _sort.Start(list).BubbleSort().ReturnList();
        return sortedList;
    }
}
