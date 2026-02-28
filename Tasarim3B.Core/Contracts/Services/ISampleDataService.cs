using Tasarim3B.Core.Models;

namespace Tasarim3B.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetGridDataAsync();
}
