using System;
using Prism.Navigation;
using Xamarin.Forms;

namespace IslahVoice.Views
{
    public partial class MasterPage : MasterDetailPage , IMasterDetailPageOptions
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get { return Device.Idiom != TargetIdiom.Phone; }
        }
    }
}
