namespace Extensions.FileProviders.AspNetCore
{
    using System;
    using System.Threading.Tasks;
    using Extensions.FileProviders;
    using Microsoft.AspNetCore.Http;
    public static class StorageProviderExtensions
    {
        public static Task<string> UploadAsync(this IStorageClient client, IFormFile file, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
