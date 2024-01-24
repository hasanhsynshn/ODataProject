using StartupAPIProject.Infrastructure.Context;
using StartupAPIProject.Infrastructure.EntityModel;
using StartupAPIProject.Models;
using StartupAPIProject.Services.Abstract;

namespace StartupAPIProject.Services.Concrete
{
    public class FilterService : IFilterService
    {
        
        private readonly StartupDbContext _context;
        public FilterService(StartupDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Product Query
        /// </summary>
        /// <returns>OData value</returns>
        public IQueryable<Product> GetProductQueryAsync()
        {
            return _context.Products.AsQueryable();
        }
    }
}
