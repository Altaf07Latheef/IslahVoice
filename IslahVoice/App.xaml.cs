using Prism.Unity;
using IslahVoice.Views;
using Xamarin.Forms;
using IslahVoice.ViewModels;

namespace IslahVoice
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("NavigationPage/MainPage");
            NavigationService.NavigateAsync("MasterPage/NavigationPage/LatestSpeech");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<LatestSpeech>();
            Container.RegisterTypeForNavigation<MasterPage>();
            Container.RegisterTypeForNavigation<Subjects>();
            Container.RegisterTypeForNavigation<Orators>();
            Container.RegisterTypeForNavigation<Downloads>();
            Container.RegisterTypeForNavigation<About>();
            Container.RegisterTypeForNavigation<SpeechList>();
         //   Container.RegisterTypeForNavigation<SpeechList, AudioViewModel>();
        }
    }
}
