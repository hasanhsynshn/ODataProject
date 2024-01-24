using Microsoft.AspNetCore.Mvc;
using StartupProject.Models;
using StartupProject.Services.Abstract;
using System.Diagnostics;

namespace StartupProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchService _searchService;
        public HomeController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        [HttpGet(Name = "Filter")]
        public async Task<IActionResult> FilterByQueryStringAsync()
        {
           var response = await _searchService.ProductSearchAsync();

            if (response != null)
                return View(response);

            return View();
        }
    }
}
