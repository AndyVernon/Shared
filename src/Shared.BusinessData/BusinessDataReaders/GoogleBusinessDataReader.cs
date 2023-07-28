using Google.Cloud.Storage.V1;
using Shared.BusinessData.Interfaces;

namespace Shared.BusinessData.BusinessDataReaders
{
    internal class GoogleBusinessDataReader : IBusinessDataReader<Google.Apis.Storage.v1.Data.Object>
    {
        private readonly GoogleBusinessDataReader _this;

        public GoogleBusinessDataReader()
        {
            _this = this;
        }

        public IEnumerable<Google.Apis.Storage.v1.Data.Object> ListFiles(string containerName)
        {
            var storage = StorageClient.Create();
            var storageObjects = storage.ListObjects(containerName);
            return storageObjects;
        }

        public Google.Apis.Storage.v1.Data.Object? GetFile(string containerName, string fileName)
        {
            var files = _this.ListFiles(containerName);
            if (files == null)
            {
                return null;
            }

            return files.FirstOrDefault(x => x.Name == fileName);
        }
    }
}
