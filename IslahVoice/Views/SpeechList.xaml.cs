using IslahVoice.ViewModels;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using System;
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
        }
    }
}
