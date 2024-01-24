using Newtonsoft.Json;
using StartupProject.Constants;
using StartupProject.Models;
using StartupProject.Services.Abstract;
using System.Net.Http.Headers;

namespace StartupProject.Services.Concrete
{
    public class SearchService : ISearchService
    {
        private readonly IHttpClientFactory _httpClient;
        public SearchService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }
        /// <summary>
        /// Mvc application calls this method to get the data from the API.
        /// </summary>
        /// <returns>View with data</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<IEnumerable<ProductViewModel>> ProductSearchAsync()
        {
            try
            {
                using (var httpClient = _httpClient.CreateClient())
                {
                    //HttpClient is created using IHttpClientFactory.
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                    var result = await httpClient.GetAsync($"{StartupConstant.BaseUrl}/search/filter-query?$filter=Id in (1,2,3)");

                    //Example queries for reviewers: 'http://localhost:7145/api/Search/filter-query?orderby=createdDate desc' => Order by createdDate desc
                    //Example queries for reviewers: 'http://localhost:7145/api/Search/filter-query?orderby=createdDate asc' => Order by createdDate asc
                    //Example queries for reviewers: 'http://localhost:7145/api/Search/filter-query?top=1' => Take top 1 or whatever you want.
                    if (result.IsSuccessStatusCode)
                    {
                        //Read the content from the API.
                        var content = await result.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(content))
                        {
                            //Deserialize the content to the model.
                            return JsonConvert.DeserializeObject<IEnumerable<ProductViewModel>>(content);
                        }
                        else
                        {
                            //We can log the exception here. For example using Serilog.
                            throw new ArgumentNullException("The content cannot be null.");
                        }
                    }
                    else
                    {
                        throw new HttpRequestException($"HTTP request failed with status code: {result.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                //We can log the exception here. For example using Serilog.
                return Enumerable.Empty<ProductViewModel>();
            }
        }
    }
}
