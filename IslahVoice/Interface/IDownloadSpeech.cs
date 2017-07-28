using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahVoice.Interface
{
   public interface IDownloadSpeech
    {
        string GetDownloadFile(string file);
    }
}
