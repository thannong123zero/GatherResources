namespace AuthenticationNAuthorizationDemo._Convergence.DataAccess.DTOs
{
    public class AccountDTO : BaseDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
