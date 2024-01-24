using StartupProject.Models;

namespace StartupProject.Services.Abstract
{
    public interface ISearchService
    {
        Task<IEnumerable<ProductViewModel>> ProductSearchAsync();
    }
}
