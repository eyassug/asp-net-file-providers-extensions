namespace Extensions.FileProviders.Google
{
    using System;
    using System.IO;
    using Microsoft.Extensions.FileProviders;
    using global::Google.Apis.Auth.OAuth2;
    using global::Google.Cloud.Storage.V1;
    using Microsoft.Extensions.Primitives;
    using System.Threading.Tasks;

    public class GoogleCloudStorageFileProvider : IFileProvider, IStorageClient
    {
        #region Fields
        readonly StorageClient _storageClient;
        readonly string _bucketName;
        #endregion

        #region Constructors
        public GoogleCloudStorageFileProvider(GoogleCredential googleCredential, string bucketName) : this(StorageClient.Create(googleCredential), bucketName)
        {
            
        }

        public GoogleCloudStorageFileProvider(string googleCredentialFilePath, string bucketName) : this(GoogleCredential.FromFile(googleCredentialFilePath), bucketName)
        {

        }

        public GoogleCloudStorageFileProvider(StorageClient storageClient, string bucketName)
        {
            _bucketName = string.IsNullOrEmpty(bucketName) ? throw new ArgumentNullException(nameof(bucketName)) : bucketName;
            _storageClient = storageClient ?? throw new ArgumentNullException(nameof(storageClient));
            _bucketName = bucketName;
        }

        #endregion

        #region IFileProvider implementation
        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            throw new NotImplementedException();
        }

        public IChangeToken Watch(string filter)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IStorageClient implementation
        public Task<string> UploadAsync(Stream fileStream, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string fileName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
