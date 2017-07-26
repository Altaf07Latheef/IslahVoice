using IslahVoice.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IslahVoice.ViewModels
{
    public class SpeechListViewModel : BaseViewModel
    {
        public Post speechList { get; set; }
        public List<AttachmentList> list { get; set; }
        INavigationService _navigationService;
        public SpeechListViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            speechList = new Post();
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            var result = parameters["Speech"];
            if(result!=null)
            {
                speechList = result as Post;

                list = speechList.pattachmentlist;
                RaisePropertyChanged("list");

            }
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
