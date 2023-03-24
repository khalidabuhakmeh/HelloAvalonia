using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using JetBrains.Annotations;

namespace HelloAvalonia.Models;

public interface ICatsImageService
{
    Task<Bitmap> GetRandomImage();
}

[UsedImplicitly]
public class CatsImageService : ICatsImageService
{
    private readonly HttpClient _httpClient;

    public CatsImageService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<Bitmap> GetRandomImage()
    {
        var bytes = await _httpClient.GetByteArrayAsync("https://cataas.com/cat");
        return new Bitmap(new MemoryStream(bytes));
    }
}