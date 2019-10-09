namespace TestingDemo2.Controllers
{
    using System.Web.Mvc;
    using TestingDemo2.Data;

    public class AdminController : Controller
    {
        private readonly IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchLoginByName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            return View();
        }
    }
}