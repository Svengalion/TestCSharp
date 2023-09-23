using ClassLibrary1;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var user = new Userochek();
            var presenter = new UserInfoPresenter(user);
            user.Email = "BooBa";
            user.Save();
            Assert.AreEqual(expected: null, actual: user.FirstName, message: "the Firstname chto-to ne tak");
            Assert.IsTrue(user.ShowFormErrors, "Okaziya");
            Assert.AreEqual(expected: "\n First Name can't be empty", actual: user.ErrorMessage, ("Darova zaybal"));
            user.FirstName = "Bob";
            user.Save();
            Assert.AreEqual(expected: "Bob", actual: user.FirstName, message: ("Chort blyat"));
            Assert.IsFalse(condition: user.ShowFormErrors, message: "AAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "ok");
        }
        class Userochek : IUserInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string ErrorMessage { get; set; }
            public bool ShowFormErrors { get; set; }
            public void Save() => SaveAttempted?.Invoke(this, EventArgs.Empty);

            public event EventHandler SaveAttempted;
        }
    }
}