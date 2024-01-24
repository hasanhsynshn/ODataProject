using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using StartupAPIProject.Models;
using StartupAPIProject.Services.Abstract;

namespace StartupAPIProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Search : ControllerBase
    {
        private readonly IFilterService _filterService;
        public Search(IFilterService filterService)
        {
            _filterService = filterService;
        }

        /// <summary>
        /// Filter by Query String
        /// </summary>
        /// <returns>Http response with data.</returns>
        [HttpGet]
        [Route("filter-query")]
        [EnableQuery]
        public IActionResult FilterByQueryString()
        {
            //OData is a protocol that allows you to create RESTful APIs by exposing queryable data sources.
            //OData builds on core protocols like HTTP and commonly accepted methodologies like REST.
            //OData also guides you about tracking changes, defining functions/actions for reusable procedures and sending asynchronous/batch requests etc.
            var query = _filterService.GetProductQueryAsync();
            if(query != null)
                return Ok(query);
        
            return NotFound();
        }
    }
}
