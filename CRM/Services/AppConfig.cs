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
        public string SoftDeleteUrl { get; set; }



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
