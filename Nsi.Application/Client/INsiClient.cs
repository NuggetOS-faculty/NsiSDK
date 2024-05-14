namespace NSISDK.Application.Models;

public interface INsiClient
{
    public Task<string> CreateProductAsync(PostCreateRequestModel request,
        IDictionary<string, string> headers);
}