using Nsi.SDK;
using NSISDK.Application.Models;

namespace NSISDK.Application.Client;

public class NsiClient(INsiApi api) : INsiClient
{
    public async Task<string> CreateProductAsync(PostCreateRequestModel request,
        IDictionary<string, string> headers)
    {
        var result = await api.CreateProductAsync(request.ToDto(), headers);
        return result;
    }
}