using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahVoice.Model
{
    public class DownloadsModel
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        public string url { get; set; }

        public string filename { get; set; }
    }
}
