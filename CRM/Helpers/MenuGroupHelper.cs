﻿using CRM.Services.APIServices;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Helpers
{
    public class MenuGroupHelper
    {
        private readonly MenuGroupAPIService _APIService;
        public MenuGroupHelper(MenuGroupAPIService aPIService)
        {
            _APIService = aPIService;
        }

        public async Task<IEnumerable<MenuGroupUI>> GetMenuGroups()
        {
            return await _APIService.GetMenuGroups();
        }
        public async Task<MenuGroupUI> GetMenuGroupByID(string ID)
        {
            return await _APIService.GetMenuGroupByID(ID);
        }
        public async Task CreateMenuGroup(MenuGroupUI model)
        {
            await _APIService.CreateMenuGroup(model);
        }
        public async Task UpdateMenuGroup()
        {

        }
        public async Task SoftDelete(string ID)
        {

        }

    }
}