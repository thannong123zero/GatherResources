namespace jwtWebAPI.Models
{
    public class RefreshTokenModel
    {
        public string UserID { get; set; }
        public string KeyRefresh { get; set; }
        public string Token { get; set; }
        public DateTime CreatedOn { get; private set; }
        public bool IsUsed { get; set; }
        public RefreshTokenModel()
        {
            CreatedOn = DateTime.Now;
            IsUsed = false;
        }
    }
}
