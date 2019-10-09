namespace TestingDemo2.Data
{
    public class DataUserRepository : IUserRepository
    {
        public void Add(User newUser)
        {
        }

        public User FetchLoginByName(string loginName)
        {
            return new User { LoginName = loginName };
        }

        public void SubmitChanges()
        {
        }
    }
}