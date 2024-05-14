using NsiSDK.Dto;

namespace NSISDK.Application.Models;

public record PostCreateRequestModel(string Title, string Content)
{
    public NsiCreatePostRequestDto ToDto()
    {
        return new NsiCreatePostRequestDto(new NsiCreatePostDto(Title, Content));
    }
}