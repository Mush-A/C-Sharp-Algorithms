using Interview.Sorting;

namespace Interview;
public class ProcessorServiceFactory : IProcessorServiceFactory
{
    public ProcessListService<T> CreateProcessListService<T>() where T : IComparable<T>
    {
        ISort<T> sort = new Sort<T>();
        return new ProcessListService<T>(sort);
    }
}
