using Skillfactory18.FinalTask;
using YoutubeExplode;
using YoutubeExplode.Converter;

var youtubecommand = new YoutubeCommand();
var youtube = new Youtube(youtubecommand);
string videoUrl = "https://youtu.be/slzTJtj4iG8";
string outputFilePath = @"C:\Users\Toshka\source\repos\Skillfactory18.FinalTask\Skillfactory18.FinalTask\bin\Debug\net7.0";


var video = youtube.GetDescription(videoUrl);

await youtube.DownloadVideo(videoUrl, outputFilePath);

Console.WriteLine("Готово.");
Console.ReadLine();