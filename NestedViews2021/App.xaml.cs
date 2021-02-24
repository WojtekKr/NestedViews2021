using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using NestedViews2021.ViewModels;
using NestedViews2021.Views;

namespace NestedViews2021
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry Container)
        {
            Container.RegisterForNavigation<MainPage, RouteViewViewModel>();
        }
    }
}
