using NSISDK.Application.Models;
using NsiSDK.Dto;

namespace NSISDK.Application.Extensions;

public static class ResponseExtensions
{
    public static NsiCreatePostResponseDto ToModel(this NsiCreatePostResponseDto dto)
    {
        return new NsiCreatePostResponseDto(dto.Title, dto.Content);
    }
}