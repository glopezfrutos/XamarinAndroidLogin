using Login.Core.Model;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Login.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand LoginCommand { get; private set; }

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new MvxAsyncCommand(Login);
        }


        private string _userId;
        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        private string _pin;
        public string Pin
        {
            get { return _pin; }
            set { SetProperty(ref _pin, value); }
        }


        private async Task Login()
        {
            User user = new User
            {
                UserId = UserId,
                Pin = Pin
            };


            if (user.UserId == "9999" && user.Pin == "1234")
            {
                await _navigationService.Navigate<WelcomeViewModel, User>(user);
            }
        }
    }
}