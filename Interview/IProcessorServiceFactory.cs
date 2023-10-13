namespace Interview;

public interface IProcessorServiceFactory
{
    ProcessListService<T> CreateProcessListService<T>() where T : IComparable<T>;
}
