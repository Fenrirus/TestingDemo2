using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestingDemo2.Data;
using System.Linq;
using TestingDemo2.Controllers;

namespace TestingDemo2.Tests
{
    [TestClass]
    public class AdminControlerTest
    {
        [TestMethod]
        public void CanChangeLoginName()
        {
            User user = new User { LoginName = "Robert" };
            FakeRepository repositoryParam = new FakeRepository();
            repositoryParam.Add(user);
            AdminController target = new AdminController(repositoryParam);
            string oldLoginParam = user.LoginName;
            string newLoginParam = "Robert";

            target.ChangeLoginName(oldLoginParam, newLoginParam);

            Assert.AreEqual(newLoginParam, oldLoginParam);
            Assert.IsTrue(repositoryParam.DidSubmitChanges);
        }

        private class FakeRepository : IUserRepository
        {
            public List<User> Users = new List<User>();
            public bool DidSubmitChanges = false;

            public void Add(User user)
            {
                Users.Add(user);
            }

            public User FetchLoginByName(string loginName)
            {
                return Users.First(m => m.LoginName == loginName);
            }

            public void SubmitChanges()
            {
                DidSubmitChanges = true;
            }
        }
    }
}