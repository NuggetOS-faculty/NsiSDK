using Nsi.SDK;
using NsiSDK;
using NSISDK.Application.Extensions;
using NSISDK.Application.Models;
using NsiSDK.Dto;

namespace NSISDK.Application.Client;

public class NsiClient(INsiApi api) : INsiClient
{
    public async Task<NsiCreatePostResponseDto> CreateProductAsync(PostCreateRequestModel request,
        IDictionary<string, string> headers)
    {
        var result = await api.CreateProductAsync(request.ToDto(), headers);
        return result.ToModel();
    }
}