using Login.Core.Model;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Login.Core.ViewModels
{
    public class WelcomeViewModel : MvxViewModel<User>
    {
        private User _user;
        public User User { get => _user; set => _user = value; }

        private string _welcomeMessage;
        public string WelcomeMessage { get => _welcomeMessage; set => _welcomeMessage = value; }


        public override void Prepare(User parameter)
        {
            // receive and store the parameter here
            _user = parameter;
        }


        public override async Task Initialize()
        {
            await base.Initialize();

            // do the heavy work here
            WelcomeMessage = "Hello, your User Id is " + User.UserId + " and your Pin is " + User.Pin;
        }
    }
}
