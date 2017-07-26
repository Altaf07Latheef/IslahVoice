using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslahVoice.Model
{
    public class AttachmentList
    {
        [JsonProperty("attachmentID")]
        public string aid { get; set; }
        [JsonProperty("attachmentTitle")]
        public string atitle { get; set; }
        [JsonProperty("attachmentFilename")]
        public string afilename { get; set; }
    }

    public class Post
    {
        [JsonProperty("itemID")]
        public string pid { get; set; }
        [JsonProperty("item")]
        public string pitem { get; set; }
        [JsonProperty("AttachmentList")]
        public List<AttachmentList> pattachmentlist { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("posts")]
        public List<Post> rposts { get; set; }
        public object Post { get; internal set; }
    }
}
