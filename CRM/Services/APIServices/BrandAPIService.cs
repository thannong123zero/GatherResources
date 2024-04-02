using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class BrandAPIService
    {
        private readonly AppConfig _appConfig;
        public BrandAPIService(AppConfig appConfig)
        {
            _appConfig = appConfig;
        }
        /// <summary>
        /// Get menugroups
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BrandUI>> GetBrands()
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getBrandsUrl = _appConfig.GetBrandsUrl;
            //string url = string.Concat(baseLink,getBrandsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getBrandsUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<BrandUI> brands = JsonConvert.DeserializeObject<IEnumerable<BrandUI>>(responseData);
                        // Return the fetched menu groups
                        return brands;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Get menu group by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<BrandUI> GetBrandByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getBrandByIDUrl = _appConfig.GetBrandByIDUrl;
            string url = string.Concat(getBrandByIDUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);

                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        BrandUI brand = JsonConvert.DeserializeObject<BrandUI>(responseData);
                        // Return the fetched menu groups
                        return brand;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Create Brand
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task CreateBrand(BrandUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addBrandUrl = _appConfig.AddBrandUrl;
            //string url = string.Concat(baseLink,getBrandsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addBrandUrl, content);
            }
        }
        /// <summary>
        /// Update Brand
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateBrand(BrandUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string updateBrandUrl = _appConfig.UpdateBrandUrl;
            //string url = string.Concat(baseLink,getBrandsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PutAsync(updateBrandUrl, content);
            }
        }
        /// <summary>
        /// Soft delele
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<bool> SoftDelete(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string softDeleteBrandUrl = _appConfig.SoftDeleteBrandUrl;
            string url = string.Concat(softDeleteBrandUrl, ID);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to BrandUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
