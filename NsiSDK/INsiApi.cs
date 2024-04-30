using NsiSDK.Dto;
using Refit;

namespace NsiSDK;

public interface INsiApi
{
    [Post("/webhook/ProductWebhook/Create/create")]
    public Task<NsiCreatePostResponseDto> CreateProductAsync(NsiCreatePostRequestDto request,
        [HeaderCollection] IDictionary<string, string> headers);
}