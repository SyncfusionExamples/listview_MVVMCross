# Working with ListView in MVVMCross

## Requirements
MVVMCross version - 6.3.1

## ListView with MVVMCross

The SfListView allows users work with MVVMCross Framework. Follow the below steps to work withMVVMCross Framework:

1. Inherit App.cs from MvxApplication instead of your application.
2. Inherit ViewModel from the MvxViewModel.
3. Connect view and view model instead of binding context by registering them.
4. Derive MainActivity and AppDelegate from MvxFormsAppCompatActivity and MvxFormsApplicationDelegate for initializing renderer.

```sh
public class CoreApp : MvvmCross.Core.ViewModels.MvxApplication
{
    public override void Initialize()
    {
        CreatableTypes()
            .EndingWith("Service")
            .AsInterfaces()
            .RegisterAsLazySingleton();

        RegisterNavigationServiceAppStart<ViewModels.MvxFormsViewModel>();
    }
}
```

```sh
public class MvxFormsViewModel : MvxViewModel
{
    public MvxFormsViewModel()
    {

    }
}
```

```sh
public class MainActivity : MvxFormsAppCompatActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);
        TabLayoutResource = Resource.Layout.Tabbar;
        ToolbarResource = Resource.Layout.Toolbar;
    }
}


public partial class AppDelegate : MvxFormsApplicationDelegate
{
    public override UIWindow Window { get; set; }

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        SfListViewRenderer.Init();
    }
}
```

For more details, refer to this [documentation](https://www.mvvmcross.com/documentation/getting-started/mvvmcross-overview).



