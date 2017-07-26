using Xamarin.Forms;

namespace IslahVoice.Views
{
    public partial class LatestSpeech : ContentPage
    {
        public LatestSpeech()
        {
            InitializeComponent();

            LatestSpeechList.ItemSelected += (s, e) =>
            {
                LatestSpeechList.SelectedItem = null;
            };
        }
    }
}
