using MvvmCross.ViewModels;
using MvvmCross.IoC;
using Login.Core.ViewModels;

namespace Login.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<LoginViewModel>();
        }
    }
}
