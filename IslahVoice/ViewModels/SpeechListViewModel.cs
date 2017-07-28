using IslahVoice.Interface;
using IslahVoice.Model;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private DelegateCommand downloadButton { get; set; }
        public string filename= null;

        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;
        INavigationService _navigationService;
        public SpeechListViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            speechList = new Post();

            playButton = new DelegateCommand(async () => await PlaybackController.Play());
            pauseButton = new DelegateCommand(async () => await PlaybackController.Pause());
            stopButton = new DelegateCommand(async () => await PlaybackController.Stop());
          
        }

        public DelegateCommand DownloadButton
        {
            get {
                
                return downloadButton = new DelegateCommand(() => StartDownloading(filename));
            }
        }

        public DelegateCommand PlayButton
        {
            get { return playButton; }
        }

        public DelegateCommand PauseButton
        {
            get { return pauseButton; }
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
                    filename = value.afilename;
                    
                    CrossMediaManager.Current.Play("http://islahvoice.com/media/k2/attachments/" + filename);
                    //downloadButton = new DelegateCommand( () => StartDownloading(value.afilename));
                }
            }
        }
        
        
        private void StartDownloading(string filename)
        {
            var downloadManager = CrossDownloadManager.Current;
           downloadManager.PathNameForDownloadedFile = new Func<IDownloadFile, string>(x => {
                 return   DependencyService.Get<IDownloadSpeech>().GetDownloadFile(filename);
            });
                var file = downloadManager.CreateDownloadFile("http://islahvoice.com/media/k2/attachments/" + filename);
            downloadManager.Start(file);
           
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
