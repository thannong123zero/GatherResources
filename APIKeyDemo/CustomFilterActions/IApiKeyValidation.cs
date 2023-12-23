namespace APIKeyDemo.CustomFilterActions
{
    public interface IApiKeyValidation
    {
        bool IsValidApiKey(string userApiKey);
    }
}
