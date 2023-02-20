using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Skillfactory18.FinalTask
{
    public interface ICommand
    {
        Task<Video> DescriptionAsync(string videoUrl);
        ValueTask Download(string videoUrl, string outputFilePath);
    }
}
