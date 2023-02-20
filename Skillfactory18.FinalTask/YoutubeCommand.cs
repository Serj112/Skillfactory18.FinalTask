using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Skillfactory18.FinalTask
{
    public class YoutubeCommand : ICommand
    {
        YoutubeClient youtube = new YoutubeClient();
        public async Task<Video> DescriptionAsync(string videoUrl)
        {
            return await youtube.Videos.GetAsync(videoUrl);
        }

        public ValueTask Download(string videoUrl, string outputFilePath)
        {
            return youtube.Videos.DownloadAsync(videoUrl, outputFilePath);
        }
    }
}
