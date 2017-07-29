using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.IO;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using IslahVoice.Droid;
using IslahVoice.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(FileDownload))]
namespace IslahVoice.Droid
{
    public class FileDownload : IDownloadSpeech
    {
        public string GetDownloadFile(string file)
        {
          
                string fileName = file;
                var c = Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity;
                return Path.Combine(c.GetExternalFilesDir(Android.OS.Environment.DirectoryDownloads).AbsolutePath, fileName);
          
        }
    }
}