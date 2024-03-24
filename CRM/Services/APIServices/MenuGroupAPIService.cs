using Microsoft.CodeAnalysis.Operations;
using Newtonsoft.Json;
using SharedLibrary.UserInterfaceDTO;
using System.Text;

namespace CRM.Services.APIServices
{
    public class MenuGroupAPIService
    {
        private readonly AppConfig _appConfig;
        public MenuGroupAPIService(AppConfig appConfig) 
        {
            _appConfig = appConfig;
        }
        public async Task<IEnumerable<MenuGroupUI>> GetMenuGroups()
        {  
            string baseLink = _appConfig.GetBaseAPIURL();
            string getMenuGroupsUrl = _appConfig.GetMenuGroupsUrl;
            //string url = string.Concat(baseLink,getMenuGroupsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                HttpResponseMessage response = await httpClient.GetAsync(getMenuGroupsUrl   );
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to MenuGroupUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if(!string.IsNullOrEmpty(responseData))
                    {
                        IEnumerable<MenuGroupUI> menuGroups = JsonConvert.DeserializeObject<IEnumerable<MenuGroupUI>>(responseData);
                    // Return the fetched menu groups
                        return menuGroups;
                    }
                }
            }
                return null;
        }
        public async Task<MenuGroupUI> GetMenuGroupByID(string ID)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string getMenuGroupByIDUrl = _appConfig.GetMenuGroupByIDUrl;
            string url = string.Concat(baseLink, getMenuGroupByIDUrl,ID);
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the response content to MenuGroupUI objects
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(responseData))
                    {
                        MenuGroupUI menuGroup = JsonConvert.DeserializeObject<MenuGroupUI>(responseData);
                        // Return the fetched menu groups
                        return menuGroup;
                    }
                }
            }

            return null;
        }
        public async Task CreateMenuGroup(MenuGroupUI model)
        {
            string baseLink = _appConfig.GetBaseAPIURL();
            string addMenuGroupUrl = _appConfig.AddMenuGroupUrl;
            //string url = string.Concat(baseLink,getMenuGroupsUrl);
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseLink);
                string json = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(addMenuGroupUrl,content);
            }
        }
        public async Task UpdateMenuGroup()
        {

        }
        public async Task SoftDelete(string ID)
        {

        }

    }
}
