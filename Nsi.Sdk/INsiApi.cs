using NsiSDK.Dto;
using Refit;

namespace Nsi.SDK;

public interface INsiApi
{
    [Post("/webhook/PostWebHook/CreatePost")]
    public Task<NsiCreatePostResponseDto> CreateProductAsync(NsiCreatePostRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
}