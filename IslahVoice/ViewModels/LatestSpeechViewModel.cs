using IslahVoice.Model;
using IslahVoice.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IslahVoice.ViewModels
{
    public class LatestSpeechViewModel : BaseViewModel
    {
      public List<Post> latestSpeech { get; set; }
        public string item;
        INavigationService _navigationService;

        public LatestSpeechViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            latestSpeech = new List<Post>();
            getDataFunc();
        }

        public async Task getDataFunc()
        {

            var remoteContent = new SpeechServices();
            var result = await remoteContent.getDataFunc();
            latestSpeech = result.ToList();
            RaisePropertyChanged("latestSpeech");
        }

        public Post SelectedSpeechItem
        {
            get { return null; }
            set
            {
                if(value!=null)
                {
                    var parameter = new NavigationParameters();
                    parameter.Add("Speech", value);
                    _navigationService.NavigateAsync(new Uri("SpeechList",UriKind.Relative),parameter);
               
                }
            }
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
