using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Skillfactory18.FinalTask
{
    public class Youtube
    {
        ICommand command;
        private Youtube()
        {

        }

        public Youtube(ICommand command)
        {
            this.command = command;
        }

        public Video GetDescription(string videoUrl)
        {
            return command.DescriptionAsync(videoUrl).Result;
        }

        public ValueTask DownloadVideo(string videoUrl, string outputFilePath)
        {
            return command.Download(videoUrl, outputFilePath);
        }
    }
}
