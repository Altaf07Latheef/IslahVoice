using IslahVoice.ViewModels;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using System.Diagnostics;
using Xamarin.Forms;

namespace IslahVoice.Views
{
    public partial class SpeechList : ContentPage 
{

        public SpeechList()
        {
            InitializeComponent();
            ListOfSpeeches.ItemSelected += (s, e) =>
             {
                 ListOfSpeeches.SelectedItem = null;
             };


            CrossMediaManager.Current.PlayingChanged += Current_PlayingChanged;

        }

        private void Current_PlayingChanged(object sender, Plugin.MediaManager.Abstractions.EventArguments.PlayingChangedEventArgs e)
        {
            ProgressBar.Progress = e.Progress;
            Debug.WriteLine("progress" + ProgressBar.Progress);
        }
    

    }
}
