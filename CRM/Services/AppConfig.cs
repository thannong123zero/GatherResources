namespace CRM.Services
{
    public class AppConfig
    {
        private string ProductMode { get; set; }
        private string ProdBaseAPIUrl { get; set; }
        private string DevBaseAPIUrl { get; set; }



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
