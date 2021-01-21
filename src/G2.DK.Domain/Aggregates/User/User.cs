namespace G2.DK.Domain.Aggregates.User
{
    public class User
    {
        private readonly string _login;
        private readonly string _password;

        public int Id { get; }
        public string Login => _login;
        public string Password => _password;

        private User() { }
    }
}
