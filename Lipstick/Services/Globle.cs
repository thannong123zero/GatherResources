namespace Lipstick.Services
{    // language code
    public enum ELanguage
    {
        VN,
        EN
    }
    public static class Globle
    {
        public static string GetLanguageCode(HttpRequest request)
        {
            string? languageCookie = request.Cookies[".AspNetCore.Culture"];
            if (!string.IsNullOrEmpty(languageCookie) && languageCookie.Contains("en-US"))
            {
                return ELanguage.EN.ToString();
            }
            else
            {
                return ELanguage.VN.ToString();
            }
        }
    }
}
