namespace CRM.Services
{
    public class AppConfig
    {
        public string ProductMode { get; set; }
        public string ProdBaseAPIUrl { get; set; }
        public string DevBaseAPIUrl { get; set; }

        public string GetMenuGroupsUrl { get; set; }
        public string GetMenuGroupByIDUrl { get; set; }
        public string AddMenuGroupUrl { get; set; }
        public string UpdateMenuGroupUrl { get; set; }
        public string DeleteMenuGroupByIDUrl { get; set; }
        public string SoftDeleteMenuGroupUrl { get; set; }
        public string RestoreMenuGroupUrl { get; set; }

        public string GetMenuItemsUrl { get; set; }
        public string GetMenuItemByIDUrl { get; set; }
        public string AddMenuItemUrl { get; set; }
        public string UpdateMenuItemUrl { get; set; }
        public string DeleteMenuItemByIDUrl { get; set; }
        public string SoftDeleteMenuItemUrl { get; set; }
        public string RestoreMenuItemUrl { get; set; }


        public string GetBaseAPIURL()
        {
            string url = DevBaseAPIUrl;
            if (ProductMode.ToUpper() == "PROD")
            {
                url = ProdBaseAPIUrl;
            }
            return url;
        }
    }
}
