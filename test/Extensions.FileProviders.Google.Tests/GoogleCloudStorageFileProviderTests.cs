namespace Extensions.FileProviders.Google.Tests
{
    using System;
    using Xunit;
    using global::Google.Apis.Auth.OAuth2;
    using global::Google.Cloud.Storage.V1;

    public class GoogleCloudStorageFileProviderTests
    {
        //readonly GoogleCloudStorageFileProvider _fileProvider;
        
        [Fact]
        public void NullStorageClient_ThrowsArgumentNullException()
        {
            StorageClient storageClient = null;
            Assert.Throws<ArgumentNullException>(() => new GoogleCloudStorageFileProvider(storageClient, "bucket"));
        }

        [Fact]
        public void NullOrEmptyBucketName_ThrowsArgumentNullException()
        {
            var credential = GoogleCredential.FromAccessToken("test_token");
            var client = StorageClient.Create(credential);
            Assert.Throws<ArgumentNullException>(() => new GoogleCloudStorageFileProvider(client, null));
            Assert.Throws<ArgumentNullException>(() => new GoogleCloudStorageFileProvider(client, string.Empty));
        }
    }
}
