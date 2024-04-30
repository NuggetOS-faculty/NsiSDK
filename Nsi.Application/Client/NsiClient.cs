using NsiSDK;
using NSISDK.Application.Extensions;
using NSISDK.Application.Models;
using NsiSDK.Dto;

namespace NSISDK.Application.Client;

public class NsiClient(INsiApi api)
{
    public async Task<NsiCreatePostResponseDto> CreateProductAsync(PostCreateRequestModel request)
    {
        var result = await api.CreateProductAsync(request.ToDto(), request.Headers);
        return result.ToModel();
    }
}