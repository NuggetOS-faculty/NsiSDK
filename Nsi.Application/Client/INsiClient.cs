using NsiSDK.Dto;
using Refit;

namespace NSISDK.Application.Models;

public interface INsiClient
{
    [Post("/webhook/PostWebHook/CreatePost")]
    public Task<string> CreateProductAsync(PostCreateRequestModel request,
        IDictionary<string, string> headers);
}