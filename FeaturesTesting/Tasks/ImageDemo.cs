using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace FeaturesTesting.Tasks
{
    public static class ImageDemo
    {

        public static Task<byte[]> DownloadImage(string url)
        {
            var client = new HttpClient();
            return client.GetByteArrayAsync(url);
        }

        public static async Task SaveImage(byte[] bytes, string imagePath)
        {
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await fileStream.WriteAsync(bytes, 0, bytes.Length);
            }
        }

        public static async Task<byte[]> BlackAndWhiteImage(string imagePath)
        {
            return await Task.Run(() =>
            {
                var image = Image.Load(imagePath);
                image.Mutate(ctx => ctx.BlackWhite());
                using (var memoryStream = new MemoryStream())
                {
                    image.SaveAsJpeg(memoryStream);
                    return memoryStream.ToArray();
                }
            });
        }
    }
}
