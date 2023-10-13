namespace Interview.Sorting;

public interface ISort<T>
{
    ISort<T> BubbleSort();
    ISort<T> Start(List<T> list);
    List<T> ReturnList();
    string Print();
}
