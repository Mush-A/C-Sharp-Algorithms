using Interview;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers;

[ApiController]
[Route("[controller]")]
public class ProcessController : ControllerBase
{
    private readonly IProcessorServiceFactory _processorServiceFactory;

    public ProcessController(IProcessorServiceFactory processorServiceFactory)
    {
        _processorServiceFactory = processorServiceFactory;
    }

    [HttpPost]
    public ActionResult<List<int>> Process([FromBody] List<int> ListReq)
    {
        var processor = _processorServiceFactory.CreateProcessListService<int>();
        return processor.SortList(ListReq);
    }
}
