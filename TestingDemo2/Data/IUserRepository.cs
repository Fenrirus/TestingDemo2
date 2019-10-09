namespace TestingDemo2.Data
{
    public interface IUserRepository
    {
        void Add(User newUser);

        User FetchLoginByName(string loginName);

        void SubmitChanges();
    }
}