using IslahVoice.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace IslahVoice.Services
{
    public class SpeechServices
    {
        public async Task<IEnumerable<Post>> getDataFunc()
        {
            IEnumerable<Post> posts = Enumerable.Empty<Post>();
            var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "http://islahvoice.com/json/latestspeeches.php";
            client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<RootObject>(content);
            return posts = Items.rposts;


        }
    }
}
