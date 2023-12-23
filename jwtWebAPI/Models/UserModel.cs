namespace jwtWebAPI.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Sex { get; set; }
        public DateTime BrithDay { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
