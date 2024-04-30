using NsiSDK.Dto;

namespace NSISDK.Application.Models;

public record PostCreateRequestModel(string Name, string Content, IDictionary<string, string> Headers)
{
    public NsiCreatePostRequestDto ToDto()
    {
        return new NsiCreatePostRequestDto(new NsiCreatePostDto(Name, Content));
    }
}