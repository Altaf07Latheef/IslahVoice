using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace IslahVoice.ViewModels
{
    public class MasterPageViewModel : BaseViewModel
    {
        public string MenuItems;
        public DelegateCommand<string> NavigationCommand { get; set; }
        INavigationService _navigationService;

        public MasterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigationCommand = new DelegateCommand<string>(Navigate);
        }

        public void Navigate(string page)
        {
            _navigationService.NavigateAsync(page);
            _navigationService.GoBackAsync();
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
        }
    }
}
