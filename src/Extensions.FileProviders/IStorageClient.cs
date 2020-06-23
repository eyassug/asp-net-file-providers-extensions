namespace Extensions.FileProviders
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IStorageClient
    {
        Task<string> UploadAsync(Stream fileStream, string fileName);
        Task DeleteAsync(string fileName);

    }
}
