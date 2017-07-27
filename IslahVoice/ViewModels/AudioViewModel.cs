using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IslahVoice.ViewModels
{
    public class AudioViewModel : BaseViewModel
    {

        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;
        private DelegateCommand pauseButton { get; set; }
        private DelegateCommand stopButton { get; set; }
        private DelegateCommand playButton { get; set; }
 
        INavigationService _navigationService;
        public AudioViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

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

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            var result = parameters["Audio"];
            if (result != null)
            {
                CrossMediaManager.Current.Play("http://islahvoice.com/media/k2/attachments/" + result);
                //PlayButton = new DelegateCommand(async () => await PlaybackController.Play());
                //PauseButton = new DelegateCommand(async () => await PlaybackController.Pause());
                //StopButton = new DelegateCommand(async () => await PlaybackController.Stop());

            }
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
