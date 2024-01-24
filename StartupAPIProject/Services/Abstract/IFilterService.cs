using StartupAPIProject.Infrastructure.EntityModel;
using StartupAPIProject.Models;

namespace StartupAPIProject.Services.Abstract
{
    public interface IFilterService
    {
        IQueryable<Product> GetProductQueryAsync();
    }
}
