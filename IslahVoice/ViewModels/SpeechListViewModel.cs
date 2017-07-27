using IslahVoice.Model;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace IslahVoice.ViewModels
{
    public class SpeechListViewModel : BaseViewModel
    {
        public Post speechList { get; set; }
        public List<AttachmentList> list { get; set; }
        private DelegateCommand pauseButton { get; set; }
        private DelegateCommand stopButton { get; set; }
        private DelegateCommand playButton { get; set; }


        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;
        INavigationService _navigationService;
        public SpeechListViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            speechList = new Post();

            playButton = new DelegateCommand(async () => await PlaybackController.Play());

            stopButton = new DelegateCommand(async () => await PlaybackController.Stop());
        }

        public DelegateCommand PlayButton
        {
            get { return playButton; }
        }

        public DelegateCommand PauseButton
        {
            get { return pauseButton = new DelegateCommand(async () => await PlaybackController.Pause()); }
        }

        public DelegateCommand StopButton
        {
            get { return stopButton; }
        }

        public AttachmentList SelectedAudioItem
        {
            get
            {
                return null;
            }
            set
            {
                if (value != null)
                {
                    //var parameter = new NavigationParameters();
                    //parameter.Add("Audio", value.afilename);
                    //_navigationService.NavigateAsync(new Uri("AudioViewModel", UriKind.Relative), parameter);
                    CrossMediaManager.Current.Play("http://islahvoice.com/media/k2/attachments/" + value.afilename);
                    ////IsPlaying = true;
                    ////PlayButton = new Command(async () => await PlaybackController.Play());
                    ////PauseButton = new Command(async () => await PlaybackController.Pause());
                    ////StopButton = new Command(async () => await PlaybackController.Stop());
                }
            }
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
