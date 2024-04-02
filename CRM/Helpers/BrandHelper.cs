using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class BrandHelper
    {
        private readonly BrandAPIService _APIService;
        public BrandHelper(BrandAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<BrandUI>> GetBrands()
        {
            return await _APIService.GetBrands();
        }
        public async Task<BrandUI> GetBrandByID(string ID)
        {
            return await _APIService.GetBrandByID(ID);
        }
        public async Task CreateBrand(BrandUI model)
        {
            await _APIService.CreateBrand(model);
        }
        public async Task UpdateBrand(BrandUI model)
        {
            await _APIService.UpdateBrand(model);
        }
        public async Task<bool> SoftDelete(string ID)
        {
            return await _APIService.SoftDelete(ID);
        }
    }
}
