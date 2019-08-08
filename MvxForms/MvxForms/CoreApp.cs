using MvvmCross.Navigation;
using MvvmCross.Platform.IoC;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvxForms.Core
{
    public class CoreApp : MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterCustomAppStart<AppStart>();
        }
    }

    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<ViewModels.MvxFormsViewModel>();
        }
    }
}
