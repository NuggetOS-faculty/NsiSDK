using NsiSDK.Dto;
using Refit;

namespace Nsi.SDK;

public interface INsiApi
{
    [Post("/webhook/PostWebHook/CreatePost")]
    public Task<string> CreateProductAsync([Body] NsiCreatePostRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
}