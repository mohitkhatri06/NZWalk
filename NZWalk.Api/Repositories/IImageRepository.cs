using NZWalk.Api.Models.Domain;
using System.Net;

namespace NZWalk.Api.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
